using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.DAL
{
    public class ReturnRet<T>
    {
       
            /// <summary>
            /// 是否成功
            /// </summary>
            public bool success { get; set; }
            /// <summary>
            /// 消息
            /// </summary>
            public string message { get; set; }
            /// <summary>
            /// 返回数据
            /// </summary>
            public T data { get; set; }
        
    }
}
