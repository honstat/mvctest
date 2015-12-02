using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LYH_JXC.DAL
{
    public class DBhelper
    {
        private static string dbProviderName = ConfigurationManager.AppSettings["providerName"];
        public static string dbConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        private DbConnection connection;
        
        public DBhelper()
        {
            this.connection = CreateConnection(DBhelper.dbConnectionString);
        }
        public SqlConnection getconnection()
        {
            return new SqlConnection(dbConnectionString);
        }
         public static DbConnection CreateConnection(string connectionString)
        {
            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(DBhelper.dbProviderName);
            DbConnection dbconn = dbfactory.CreateConnection();
            dbconn.ConnectionString = connectionString;
            return dbconn;
        }
         public DbCommand GetSqlStringCommond(string sqlQuery)
         {
             DbCommand dbCommand = connection.CreateCommand();
             dbCommand.CommandText = sqlQuery;
             dbCommand.CommandType = CommandType.Text;
             return dbCommand;
         }
    }
}
