using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class SalesDAL : BaseDAL
    {

        public static List<Sales> Getlist(int empid)
        {
            using (BaseContext _db = new BaseContext())
            {
                //获取销售记录
                var query = _db.a_Sales.AsNoTracking().
                  Where(l =>
               l.EmpId == empid && l.Num > 0).ToList();
                return query;
            }
        }
        public static List<Sales> Getlist()
        {
            using (BaseContext _db = new BaseContext())
            {
                //获取销售记录
                var query = _db.a_Sales.AsNoTracking().
                  Where(l =>l.Num > 0).ToList();
                return query;
            }
        }
        /// <summary>
        /// 统计某商品销售数量
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public static int getSalesNums(int goodsId)
        {
            using (BaseContext _db = new BaseContext())
            {
                try
                {
                    //获取销售记录
                    var query = _db.a_Sales.AsNoTracking().
                      Where(l =>
                   l.GoodsId == goodsId).Sum(x => x.Num);
                    return query;
                }
                catch (Exception)
                {

                    return 0;
                }
             
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool add(Sales model)
        {
            var sql = string.Format("insert into dbo.a_Sales values({0},'{1}',{2},{3},{4})", model.GoodsId, model.AddTime.ToString(), model.EmpId,model.Price, model.Num);
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
        public static void edit(Sales model)
        {
            EditEntry<Sales>(model, "GoodsId");
        }
    }
}
