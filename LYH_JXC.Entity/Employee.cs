using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LYH_JXC.Entity
{
        [Table("a_Emp")]
    public class Employee
    {
            [Key]
        public int EmpId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string EmpName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDay { get; set; }
           
        /// <summary>
        /// 部门
        /// </summary>
        public int DepId { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 登录密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 用户身份权限
        /// </summary>
        public int Role { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 关联主表
        /// </summary>
        [ForeignKey("DepId")]
        public Dept Dept { get; set; }
    }
}
