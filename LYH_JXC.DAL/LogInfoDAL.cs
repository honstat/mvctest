using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
namespace LYH_JXC.DAL
{
    public class LogInfoDAL:BaseDAL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static LogInfo add(LogInfo model)
        {
            return AddModel<LogInfo>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(LogInfo model)
        {
            EditEntry<LogInfo>(model, "Id");
        }
    }
}
