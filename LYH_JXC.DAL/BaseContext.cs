using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
using System.Data.SqlClient;
namespace LYH_JXC.DAL
{
    public class BaseContext:DbContext
    {
        public BaseContext()
            : base("name=connectionString")
        {

        }


        public DbSet<Dept> a_Dept { get; set; }
        public DbSet<Dic> a_Dic { get; set; }
        public DbSet<Employee>a_Emp { get; set; }
        public DbSet<Goods> a_Goods { get; set; }
        public DbSet<LogInfo> a_Log { get; set; }
        public DbSet<Sales> a_Sales { get; set; }
        public DbSet<Stock> a_Stock { get; set; }
        public DbSet<Supplier> a_Supplier { get; set; }
        public DbSet<Ware> a_Ware { get; set; }
        public DbSet<WarnLog> a_WareLog { get; set; }

       
    }
}
