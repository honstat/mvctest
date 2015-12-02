using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class WareDAL:BaseDAL
    {

        public static List<Ware> Getlist()
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = _db.a_Ware.AsNoTracking().ToList();
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
        public static Ware add(Ware model)
        {
            return AddModel<Ware>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Ware model)
        {
            EditEntry<Ware>(model, "WareId");
        }
    }
}
