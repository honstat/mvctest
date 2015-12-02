using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
   [Table("a_Log")]
    /// <summary>
    /// 日志记录表
    /// </summary>
    public class LogInfo
    {
       public LogInfo() { }
       public LogInfo(int id,int typeid, int empid,int operid,int num, DateTime opertime) 
       {
           Id = id;
           TypeId = typeid;
           EmpId = empid;
           OperId = operid;
           Num = num;
           OperTime = opertime;
       }
       [Key]
        public int Id { get; set; }
        /// <summary>
        /// 身份类型（如果是库存 则为1 如果是销售则为2）
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 员工
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 操作类型（1为add 2为修改 3为删除）
        /// </summary>
        public int OperId { get; set; }
        /// <summary>
        /// 数量（除新增外  如果是在原有基础上增加了的话  则为正数  反之,如果是在原有基础上减少的话 则为负数）
        /// </summary>

        public int Num { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OperTime { get; set; }
    }
}
