using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LYH_JXC.DAL;
using LYH_JXC.Entity;
namespace LYH_JXC
{
    public partial class FrmLogin : BaseForm
    {
       
        public FrmLogin()
        {
            InitializeComponent();
            try
            {
                getskin();//加载皮肤
            }
            catch (Exception)
            {
            }
        }
        private void getskin()
        {
           
            string skinname = ConfigurationManager.AppSettings["SkinName"].ToString();


            
            this.skinEngineOne.SkinAllForm = true;//所有窗体均应用此皮肤
            if (string.IsNullOrEmpty(skinname))
            {
                this.skinEngineOne.SkinFile = Application.StartupPath + "\\skin/MSN.ssk";
            }
            else
            {
                this.skinEngineOne.SkinFile = Application.StartupPath + "\\skin/" + skinname + ".ssk";
            }
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginName = txtLoginName.Text.Trim();
            string LoginPwd = txtLoginPwd.Text.Trim();
            if (string.IsNullOrEmpty(LoginName)) 
            {
                MessageBox.Show("请输入用户名");
            }
            else if (string.IsNullOrEmpty(LoginPwd))
            {
                MessageBox.Show("请输入密码");
            }
            else 
            {
                string msg = string.Empty;
                LYH_JXC.Entity.Employee user = Login(LoginName, LoginPwd, out msg);
                if (user != null)
                {
                    //保存权限和用户信息
                    currentUser = user;
                    myPermissionList = new List<string>() { currentUser.Role.ToString() };
                   
                    //登录成功，跳转
                    FrmMain main = new FrmMain();
                    
                    this.Hide();
                    main.Show();
                    
                }
                else 
                {
                    //登录失败，弹出信息
                    MessageBox.Show(msg);
                }
            }
        }

        private LYH_JXC.Entity.Employee Login(string name, string pwd, out string msg)
        {
            LYH_JXC.Entity.Employee model = null;
            var ret = EmployeeDAL.Login(name, pwd);
          if (ret.success)
          {

              model = ret.data;
              msg = ret.message;
          }
          else 
          {
              msg = ret.message;
          }
          return model;  
        }
    }
}
