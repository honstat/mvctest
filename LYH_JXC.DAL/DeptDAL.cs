using LYH_JXC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.DAL
{
    public class DeptDAL:BaseDAL
    {

        public static List<Dept> getlist()
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = from s in _db.a_Dept.AsNoTracking() select s;
               
                var list = query.ToList();
                return list;
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Dept add(Dept model)
        {
            return AddModel<Dept>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Dept model)
        {
            EditEntry<Dept>(model, "DeptId");
        }
    }
}
