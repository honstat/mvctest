using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class GoodsDAL:BaseDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Goods add(Goods model)
        {
            return AddModel<Goods>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Goods model)
        {
            EditEntry<Goods>(model, "GoodsId");
        }
   
        public static List<Goods> Getlist(string str, int intFalg, out int total)
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = new List<Goods>();
                try
                {
                    switch (intFalg)
                    {
                        case 1:
                            query = _db.a_Goods.AsNoTracking().
                             Where(l =>
                          l.GoodsName.Contains(str) || string.IsNullOrEmpty(str)).ToList();
                            break;
                        case 2:
                            query = _db.a_Goods.AsNoTracking().
                              Where(l => l.GoodsId.ToString().Contains(str) || string.IsNullOrEmpty(str)).ToList();
                            break;

                        default:
                            query = _db.a_Goods.AsNoTracking().ToList();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    
                    throw ex ;
                }
            

                total = query.Count();
                var list = query.ToList();
                return list;
            }
            //供应商名称1//联系人2

        }
        public static bool checkloginName(string name,int goodid)
        {
            using (BaseContext _db = new BaseContext())
            {

                Goods query = _db.a_Goods.AsNoTracking().
                               Where(l =>
                            l.GoodsName == name && (goodid==0 ||l.GoodsId != goodid)).FirstOrDefault();
                if (query == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
