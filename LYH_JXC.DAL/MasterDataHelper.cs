using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.DAL
{
    public class MasterDataHelper
    {
        public void huanyuan(string path,string dbbasename)
        {

            SqlConnection con = new SqlConnection(new DBhelper().getconnection().ConnectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string DateStr = "server=.;Database=master;trusted_connection=yes";
            SqlConnection conn = new SqlConnection(DateStr);
            conn.Open();
            //-------------------杀掉所有连接 db_CSManage 数据库的进程--------------
            string strSQL = "select spid from master..sysprocesses where dbid=db_id('" + dbbasename + "')";
            SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);
            DataTable spidTable = new DataTable();
            Da.Fill(spidTable);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
            {
                cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString(); //强行关闭用户进程
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            conn.Dispose();
            //--------------------------------------------------------------------
            SqlConnection sqlcon = new SqlConnection(DateStr);

            SqlCommand sqlcmd = new SqlCommand("backup log " + dbbasename + " to disk='" + path.Trim() + "' restore database " + dbbasename + " from disk='" + path.Trim() + "'", sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
            sqlcon.Close();
            sqlcon.Dispose();
        }
        public bool back(string path, string name, string dbbasename)
        {
            bool isok = false;
            SqlConnection conn = new SqlConnection(new DBhelper().getconnection().ConnectionString);
            try
            {
                conn.Open();
                string strBacl = "backup database " + dbbasename + " to disk='" + path.Trim() + "\\" + name.Trim() + ".bak'";
                SqlCommand cmd = new SqlCommand(strBacl, conn);

                if (cmd.ExecuteNonQuery() != 0)
                {
                 
                    isok= true;
                }
                else
                {
                    
                    isok= false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                conn.Close();
            }

            return isok;    
        }
    }
}
