using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LYH_JXC.DAL
{
    public class BaseDAL
    {
        public static TEntity AddModel<TEntity>(TEntity entry) where TEntity : class
        {
            using (BaseContext _db = new BaseContext())
            {
                _db.Set<TEntity>().Add(entry);
                _db.SaveChanges();
                return entry;
            }
        }


        public static bool AddModel<TEntity>(List<TEntity> entry) where TEntity : class
        {
            using (BaseContext _db = new BaseContext())
            {
                _db.Set<TEntity>().AddRange(entry);
                _db.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TEntity getEntryById<TEntity, T>(T id) where TEntity : class
        {
            using (BaseContext _db = new BaseContext())
            {
                return _db.Set<TEntity>().Find(id);
            }
        }
        /// <summary>
        /// 修改实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entry"></param>
        /// <param name="ID"></param>
        public static void EditEntry<TEntity>(TEntity entity, string ID) where TEntity : class
        {
            using (BaseContext _db = new BaseContext())
            {
                _db.UpdateEntryByProperty<TEntity>(entity, ID);
            }
        }
        /// <summary>
        /// 根据id删除实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        public static void DeleteEntry<TEntity, T>(T id) where TEntity : class
        {
            using (BaseContext _db = new BaseContext())
            {
                TEntity entity = _db.Set<TEntity>().Find(id);
                _db.Set<TEntity>().Attach(entity);
                _db.Set<TEntity>().Remove(entity);
                _db.SaveChanges();
            }
        }

    }
    public static class UpdateExtension
    {
        public static int UpdateEntryByProperty<T>(this BaseContext _db, T entity, string EntityKey) where T : class
        {
            DbSet<T> dbSet = _db.Set<T>();
            dbSet.Attach(entity);
            MemberInfo[] members = entity.GetType().GetMembers();
            IEnumerable<MemberInfo> properties = members.Where(m => m.MemberType == MemberTypes.Property && m.Name != EntityKey);
            foreach (MemberInfo mInfo in properties)
            {

                object o = entity.GetType().InvokeMember(mInfo.Name, BindingFlags.GetProperty, null, entity, null);
                if (o != null)
                {
                    if (o.GetType().IsPrimitive || o.GetType().IsPublic)
                    {
                        try
                        {
                            DbEntityEntry entry = _db.Entry<T>(entity);
                            entry.Property(mInfo.Name).IsModified = true;
                        }
                        catch
                        {

                        }
                    }
                }
            }

            return _db.SaveChanges();
        }
    }
}
