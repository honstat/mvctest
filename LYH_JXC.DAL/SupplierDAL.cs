using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class SupplierDAL:BaseDAL
    {

        public static List<Supplier> Getlist(string str, int intFalg, out int total)
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = new List<Supplier>();
                switch (intFalg)
                {
                    case 1:
                        query = _db.a_Supplier.AsNoTracking().
                         Where(l =>
                      l.Name.Contains(str) || string.IsNullOrEmpty(str)).ToList();
                        break;
                    case 2:
                        query = _db.a_Supplier.AsNoTracking().
                          Where(l => l.Director.Contains(str) || string.IsNullOrEmpty(str)).ToList();
                        break;

                    default:
                        query = _db.a_Supplier.AsNoTracking().ToList();
                        break;
                }

                total = query.Count();
                var list = query.ToList();
                return list;
            }
            //供应商名称1//联系人2

        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Supplier add(Supplier model)
        {
            return AddModel<Supplier>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Supplier model)
        {
            EditEntry<Supplier>(model, "SupplierId");
        }
        public static bool checkloginName(string name,int id=0)
        {
            
            using (BaseContext _db = new BaseContext())
            { 
                if (id == 0)
                {
                    var query = _db.a_Supplier.AsNoTracking().
                       Where(l =>
                    l.Name.Contains(name)).FirstOrDefault();
                    if (query != null)
                    {
                        return true;
                    }
                }
                else 
                {
                    var query = _db.a_Supplier.AsNoTracking().
                       Where(l =>
                    l.Name.Contains(name) && l.SupplierId != id).FirstOrDefault();
                    if (query != null) 
                    {
                        return true;
                    }
                }



                return false;
            }
        }
    }
}
