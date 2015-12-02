using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYH_JXC.Entity;
using LYH_JXC.Common;
namespace LYH_JXC.DAL
{
    public class EmployeeDAL:BaseDAL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public static ReturnRet<Employee> Login(string username, string password)
        {
            ReturnRet<Employee> ret = new ReturnRet<Employee>();
            ret.success = false;
            using (BaseContext _db = new BaseContext())
            {
                var query = from s in _db.a_Emp
                            where s.EmpName == username
                            select s;
                Employee user = query.FirstOrDefault();
                if (user == null)
                {
                    ret.message = "找不到账号";
                    return ret;
                }

                if (user.Pwd != EncryptHelper.MD5Encrypt(password))
                {
                    ret.message = "密码错误";
                    return ret;
                }
                ret.success = true;
                ret.message = "登录成功";
                ret.data = user;
            }
            return ret;
        }
        public static List<Employee> Getlist(string str, int intFalg,out int total)
        {
            using (BaseContext _db = new BaseContext())
            { 
                var query= new List<Employee>();
                switch (intFalg)
                {
                    case 1:
                          query = _db.a_Emp.AsNoTracking().
                           Where(l =>
                        l.RealName.Contains(str)||string.IsNullOrEmpty(str)).ToList();
                        break;
                    case 2:
                         query = _db.a_Emp.AsNoTracking().
                           Where(l => l.Sex.Contains(str) || string.IsNullOrEmpty(str)).ToList();
                        break;
                    case 3:
                          query = _db.a_Emp.AsNoTracking().
                           Where(l =>(l.DepId == 3)).ToList();//销售部
                        break;
                    case 4:
                        query = _db.a_Emp.AsNoTracking().Where(l =>(l.DepId == 2)).ToList();//采购部
                        break;
                    case 5:
                        query = _db.a_Emp.AsNoTracking().Where(l => (l.DepId == 1)).ToList();//管理部
                        break;
                   
                       
                       
                    default:
                          query = _db.a_Emp.Include("Dept").AsNoTracking().ToList();
                        break;
                }
             
                total = query.Count();
                var list = query.ToList();
                return list;
            }
            //员工姓名1//员工性别2//员工所属部门3//员工职位4
           
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int add(Employee model)
        {
            var sql = string.Format(@"INSERT INTO [a_Emp]([EmpName],[Sex],[BirthDay],[DepId] ,[Phone],[Email],[Address],[Remark],[Pwd],[Role],[CreateTime],[UpdateTime],[RealName]) VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}',{9},'{10}','{11}','{12}')", model.EmpName, model.Sex, model.BirthDay, model.DepId, model.Phone, model.Email, model.Address, model.Remark, model.Pwd, model.Role, model.CreateTime, model.UpdateTime, model.RealName);
            using (BaseContext db = new BaseContext())
            {
                var result = db.Database.ExecuteSqlCommand(sql);
                return result;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public static void edit(Employee model)
        {
            EditEntry<Employee>(model, "EmpId");
        }
        public static bool checkloginName(string name)
        {
            using (BaseContext _db = new BaseContext())
            {

                Employee query = _db.a_Emp.AsNoTracking().
                               Where(l =>
                            l.EmpName == name).FirstOrDefault();
                if (query == null)
                {
                    return false;
                }
                else 
                {
                    return true;
                }
            }
        }
    }
}
