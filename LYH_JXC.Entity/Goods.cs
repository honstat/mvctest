using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
     [Table("a_Goods")]
    /// <summary>
    /// 商品表
    /// </summary>
    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        /// 商品单位编号
        /// </summary>
        public int KeyUnitId { get; set; }
        /// <summary>
        /// 商品品牌编号
        /// </summary>
        public int KeyBrandId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 商品类型编号
        /// </summary>
        public int KeyTypeId { get; set; }

        /// <summary>
        /// 商品库存预警值
        /// </summary>
        public int WarnNum { get; set; }
    }
}
