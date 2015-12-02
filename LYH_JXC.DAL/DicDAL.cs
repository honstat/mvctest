using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class DicDAL:BaseDAL
    {
        public static List<Dic> Getlist(string str, int intFalg, out int total)
        {
            using (BaseContext _db = new BaseContext())
            {
                var query = new List<Dic>();
                switch (intFalg)
                {
                    case 1:
                        query = _db.a_Dic.AsNoTracking().
                         Where(l =>
                      l.KeyType == "商品单位").OrderBy(x => x.SortId).ToList();
                        break;
                    case 2:
                        query = _db.a_Dic.AsNoTracking().OrderBy(x => x.SortId).ToList();
                        break;
                    case 3:
                        query = _db.a_Dic.AsNoTracking().Where(l =>
                      l.KeyType == "商品品牌").OrderBy(x => x.SortId).ToList();
                        break;
                    case 4:
                        query = _db.a_Dic.AsNoTracking().Where(l =>
                      l.KeyType == "商品类别").OrderBy(x => x.SortId).ToList();
                        break;

                    default:
                        query = _db.a_Dic.AsNoTracking().Where(l=>l.KeyType == "商品单位").OrderBy(x=>x.SortId).ToList();
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
        public static Dic add(Dic model)
        {
            return AddModel<Dic>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Dic model)
        {
            EditEntry<Dic>(model, "KeyId");
        }
    }
}
