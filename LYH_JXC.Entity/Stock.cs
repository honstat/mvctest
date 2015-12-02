using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
     [Table("a_Stock")]
    /// <summary>
    /// 商品库存表
    /// </summary>
    public class Stock
    {
        
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
         [Key]
        /// <summary>
        /// 入库记录时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 仓库编号
        /// </summary>
        public int WareId { get; set; }
        /// <summary>
        /// 进货价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 进货数量
        /// </summary>
        public int Num { get; set; }
        

    }
}
