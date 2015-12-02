using LYH_JXC.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.DAL
{
    public class WarnLogDAL:BaseDAL
    {
        public static List<WarnLog> getlist() 
        {
       
            using (BaseContext _db = new BaseContext())
            {
                //获取销售记录
                var query = _db.a_WareLog.AsNoTracking().ToList();
                return query;
            }
        
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static WarnLog add(WarnLog model)
        {
            return AddModel<WarnLog>(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(WarnLog model)
        {
            EditEntry<WarnLog>(model, "Id");
        }
        /// <summary>
        /// 数据备份
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool dbbaseback(string sql)
        {
            closeconn("d://", "LYH_JXC2");
            //using (BaseContext db = new BaseContext())
            //{
            //    var querylist = db.Database.ExecuteSqlCommand(sql);
            //    if (querylist > 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            return true;
        }
        public static void closeconn(string path,string dbbaseName) 
        {
            ////-------------------杀掉所有连接 db_CSManage 数据库的进程--------------
            string strSQL = "select spid from master..sysprocesses where dbid=db_id('" + dbbaseName + "')";
            SqlConnection conn = new SqlConnection(new DBhelper().getconnection().ConnectionString);
            SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn.ConnectionString);
            DataTable spidTable = new DataTable();
            Da.Fill(spidTable);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
            {
                cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString(); //强行关闭用户进程
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            conn.Dispose();

          
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string DateStr = "server=.;Database=master;user =sa;password =123456; Integrated Security=True";
          
            //--------------------------------------------------------------------
            SqlConnection sqlcon = new SqlConnection(DateStr);
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("backup log " + dbbaseName + " to disk='" + path + "' restore database db_CSManage from disk='" + path + "'",sqlcon);
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
            sqlcon.Close();
            sqlcon.Dispose();
           
        }
        
    }
}
