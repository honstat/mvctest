using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.Entity
{
      [Table("a_WarnLog")]
    /// <summary>
    /// 库存预警日志
    /// </summary>
    public class WarnLog
    {
        public WarnLog() { }

        public WarnLog(int id,int goodsid,DateTime addtime,int onlynum,bool isread)
        {
            Id = id;
            GoodsId = goodsid;
            AddTime = addtime;
            OnlyNum = onlynum;
            IsRead = isread;
        }

        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        ///添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int OnlyNum { get; set; }
        /// <summary>
        /// 是否已读
        /// </summary>
        public bool IsRead { get; set; }
       
    }
}
