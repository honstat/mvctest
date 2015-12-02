using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
      [Table("a_Sales")]
    /// <summary>
    /// 销售记录表
    /// </summary>
    public class Sales
    {
      
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
            [Key]
        /// <summary>
        /// 销售时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public int Num { get; set; }
       
    }
}
