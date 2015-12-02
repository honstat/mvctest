using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class StockDAL : BaseDAL
    {

        public static List<Stock> Getlist(string str, int intFalg, out int total)
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = new List<Stock>();
                switch (intFalg)
                {

                    case 1:
                        query = _db.a_Stock.AsNoTracking().
                          Where(l => l.GoodsId.ToString().Contains(str) || string.IsNullOrEmpty(str)).ToList();
                        break;

                    default:
                        query = _db.a_Stock.AsNoTracking().ToList();
                        break;
                }

                total = query.Count();
                var list = query.ToList();
                return list;
            }
            //供应商名称1//联系人2

        }

        private static int getStockgoosNum(int goodsId)
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = _db.a_Stock.AsNoTracking().
                          Where(l =>
                       l.GoodsId == goodsId).Sum(x => x.Num);

                return query;
            }
            //供应商名称1//联系人2

        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool add(Stock model)
        {
            var sql = string.Format("insert into dbo.a_Stock values({0},'{1}',{2},{3},{4},{5})", model.GoodsId, model.AddTime.ToString(), model.EmpId, model.WareId, model.Price, model.Num);
            using (BaseContext db = new BaseContext())
            {
                var querylist = db.Database.ExecuteSqlCommand(sql);
                if (querylist > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Stock model)
        {
            EditEntry<Stock>(model, "AddTime");
        }

        public static List<Stockty> queryForList(string sql)
        {

            List<Stockty> list = null;
            using (BaseContext _db = new BaseContext())
            {
                var result = _db.Database.SqlQuery<Stockty>(sql).ToList();
                if (result != null)
                {
                    list = result;
                }
                else
                {
                    list = new List<Stockty>();
                }
            }
            return list;
        }
        /// <summary>
        /// 查询库存数量
        /// </summary>
        /// <returns></returns>
        public static ReturnRet<int> QueryGoodsNum(int goodsId, int salesNum)
        {
            //获取商品的预警值

            int warnNum = GoodsDAL.getEntryById<Goods, int>(goodsId).WarnNum;
            ReturnRet<int> ret = new ReturnRet<int>();
            //查询库存商品
            int stocknums = getStockgoosNum(goodsId);
            //统计销售记录
            int salesnums = SalesDAL.getSalesNums(goodsId);
            if (stocknums >= (salesnums + salesNum))
            {
                //库存足够
                ret.success = true;
                ret.data = stocknums - salesnums; //除去销售记录，返回库存剩余数量
                //计算是否到达预警值
                if ((stocknums - (salesnums + salesNum)) <= warnNum)
                {
                    //需要预警,插入一条记录
                    WarnLogDAL.add(new WarnLog(0, goodsId, DateTime.Now, (stocknums - (salesnums + salesNum)), false));
                }

            }
            else
            {
                ret.success = false;
                ret.message = "库存数量不足";
                ret.data = stocknums - salesnums; //除去销售记录，返回库存剩余数量

            }
            return ret;
        }

        public static List<StcokQueryty> GetStocklist(string str, int intFalg)
        {

            //统计库存
            List<StcokQueryty> stocklist = GetDatabySql(getsql(str, intFalg));
            //统计销售记录
            List<Sales> saleslist = SalesDAL.Getlist();
            if (stocklist != null && stocklist.Count > 0)
            {
                if (saleslist != null && saleslist.Count > 0)
                {
                    //拼接数据
                    foreach (Sales sale in saleslist)
                    {
                        foreach (StcokQueryty stock in stocklist)
                        {
                            if (sale.GoodsId == stock.GoodsId)
                            {
                                stock.Num -= sale.Num;
                            }
                        }

                    }
                    return stocklist;
                }
                else
                {
                    //直接返回stocklist内的数据
                    return stocklist;
                }
            }
            else
            {
                return null;
            }
        }
        private static string getsql(string str, int intFalg)
        {
            string sql = "select GoodsId,SUM(Num)'Num' from a_Stock"; 
            switch (intFalg)
            {
                case 1:
                    if (!string.IsNullOrEmpty(str)) 
                    {
                        sql += " where GoodsId=" + str;
                    }     
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(str))
                    {
                        sql += " where GoodsId=" + str;
                    }    
                 
                    break;
                case 3:
                  
                    break;
                case 4:
                    if (!string.IsNullOrEmpty(str))
                    {
                        sql += " where GoodsId in(" + str + ")";
                    }    
                   
                    break;
                default:
                    break;
            }

            return sql+=" group by GoodsId";
        }
        private static List<StcokQueryty> GetDatabySql(string sql)
        {

            using (BaseContext db = new BaseContext())
            {
                var querylist = db.Database.SqlQuery<StcokQueryty>(sql).ToList();
                return querylist;
            }
        }
    }
}
