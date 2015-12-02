using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
     [Table("a_Ware")]
    /// <summary>
    /// 仓库表
    /// </summary>
    public class Ware
    {
        [Key]
        /// <summary>
        /// 仓库编号
        /// </summary>
        public int WareId { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>

        public int EmpId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
      
    }
}
