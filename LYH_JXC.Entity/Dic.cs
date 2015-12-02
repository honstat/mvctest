using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
        [Table("a_Dic")]
    /// <summary>
    /// 单位，品牌
    /// </summary>
    
    public class Dic
    {
        [Key]
        public int KeyId { get; set; }
        /// <summary>
        /// 类型  商品单位  商品品牌
        /// </summary>
        public string KeyType { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string KeyName { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int? SortId { get; set; }
       
    }
}
