using LYH_JXC.Common;
using LYH_JXC.DAL;
using LYH_JXC.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC
{
    public partial class FrmModifyPwd : BaseForm
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string old =txtOldPwd.Text.Trim();
            if (old == "") 
            {
                MessageBox.Show("原密码不能为空");
                return;
            }
            string New = txtNewPwd.Text.Trim();
            if (New != "")
            {
                if (New.Length < 5 || New.Length > 20)
                {
                    MessageBox.Show("新密码长度建议在5～20之间");
                    return;
                }
            }
            else
            {
                MessageBox.Show("新密码不能为空");
                return;
            }
            string Again =this.txtAgainPwd.Text.Trim();
            if (Again != New) 
            {
                MessageBox.Show("确认密码和新密码不一致");
                txtAgainPwd.Text = "";
                return;
            }
           Employee model = EmployeeDAL.getEntryById<Employee, long>(currentUser.EmpId);
           if (model == null)
           {
               MessageBox.Show("未获取到当前用户的信息，请退出重新登录");
               return;
           }
           else 
           {
               model.Pwd = model.Pwd = EncryptHelper.MD5Encrypt(New);//加密
               EmployeeDAL.EditEntry<Employee>(model, "EmpId");
               currentUser.Pwd = model.Pwd;//更新当前用户的密码
               MessageBox.Show("密码已修改成功");
               this.Close();
           }
        }


       
    }
}
