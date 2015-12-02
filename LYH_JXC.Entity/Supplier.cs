using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
    [Table("a_Supplier")]
    /// <summary>
    /// 采购记录表
    /// </summary>
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Phone { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }

        public string Remark { get; set; }
    }
}
