 using LYH_JXC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC
{
    public class BaseForm : Form
    {
        /// <summary>
        /// 当前登录用户
        /// </summary>
        /// <returns></returns>
        protected static LYH_JXC.Entity.Employee currentUser;

        /// <summary>
        /// 权限列表
        /// </summary>
        protected static List<string> myPermissionList;

        protected override void OnLoad(EventArgs e)
        {
            if (currentUser == null) 
            {
                currentUser = new LYH_JXC.Entity.Employee();
                myPermissionList = new List<string>();
            }
           
        }
    }
}
