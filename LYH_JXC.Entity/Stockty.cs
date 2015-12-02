using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.Entity
{
    public class Stockty
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WareName { get; set; }

        /// <summary>
        /// 入库记录时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 进货人
        /// </summary>
        public string RealName { get; set; }
      
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
