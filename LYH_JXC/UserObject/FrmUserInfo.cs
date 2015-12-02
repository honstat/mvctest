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
using LYH_JXC.Common;
namespace LYH_JXC
{
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }
        public static int intFalg = 0;//控件方法状态
        Employee employee = new Employee();
        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            txtEmpName.Text = "";
            txtEmpLoginName.Text = "";
            txtEmpLoginPwd.Text = "";
            txtEmpPhone.Text = "";
           
            cmbEmpDept.SelectedIndex = 0;
            cmbEmpPost.SelectedIndex = 0;
            cbxsex.SelectedIndex = 0;
            this.daEmpBirthday.Value = DateTime.Now;
        }
        /// <summary>
        /// 控制控件状态
        /// </summary>
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;
        }
        private void BindData(string txtStr, int intFalg)
        {
            int total = 0;
            try
            {
                List<Employee> list = EmployeeDAL.Getlist(txtStr, intFalg, out total);
               
                if (list != null && list.Count > 0)
                {
                    dgvlist.RowCount = list.Count;
                    for (int i = 0; i < list.Count; i++)
                    {

                        dgvlist[0, i].Value = list[i].EmpId.ToString();
                        dgvlist[1, i].Value = list[i].EmpName.ToString();
                        dgvlist[2, i].Value = list[i].RealName.ToString();
                        dgvlist[3, i].Value = list[i].Sex.ToString();
                        dgvlist[4, i].Value = list[i].Dept.DeptName.ToString();
                        dgvlist[5, i].Value = list[i].Dept.EmpId != list[i].EmpId ? "员工" : "组长";
                        dgvlist[6, i].Value = string.IsNullOrEmpty(list[i].Phone) ? "" : list[i].Phone.ToString();
                    }

                }
                else 
                {
                    dgvlist.Rows.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
        private void BindDropList()
        {
            List<Dept> list = DeptDAL.getlist();
            if (list != null && list.Count > 0)
            {
                cmbEmpDept.DataSource = list;
                cmbEmpDept.DisplayMember = "DeptName";
                cmbEmpDept.ValueMember = "DeptId";

            }

        }
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            BindDropList();
            BindData("", 0);
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            string cbxtype = cbxCondition.Text.Trim().ToString();
            if (cbxtype == null)
            {
                MessageBox.Show("请输入查询条件");
                return;
            }
           
            //判断查询类型
            string type = cbxCondition.Text.Trim().ToString();
            int flag = 0;
            switch (type)
            {


                case "员工姓名":
                    flag = 1;
                    break;
                case "员工性别":
                    flag = 2;
                    break;
                case "所属部门":
                    flag = 3;
                    break;
                case "员工职位":
                    flag = 4;
                    break;
                default:
                    break;
            }
            //获取查询条件并查询
            BindData(txtKeyWord.Text.Trim(), flag);
        }
        public int getPan()
        {
            string strEmpId = "";
            int intFalg1 = 0;
            if (intFalg != 3)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("员工姓名不能为空！", "提示");
                    txtEmpName.Focus();
                    return intFalg1;
                }
                if (txtEmpLoginName.Text == "")
                {
                    MessageBox.Show("登录名称不能为空！", "提示");
                    return intFalg1;
                }
                if (intFalg != 2)
                {
                    if (txtEmpLoginPwd.Text == "")
                    {
                        MessageBox.Show("登录密码不能为空！", "提示");
                        return intFalg1;
                    }
                }

                if (intFalg == 2)
                {
                    strEmpId = this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString();
                }
                else
                {
                    strEmpId = string.Empty;// tbMenthod.tb_EmpInfoID();
                }
            }
            else
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("请在下面选择要删除的记录", "提示");
                    return intFalg1;
                }
                else
                {
                    strEmpId = this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString();
                }
            }
            if (intFalg > 1) 
            {
                employee.EmpId = Convert.ToInt32(strEmpId);
            }
            employee.RealName = txtEmpName.Text.Trim();
            employee.EmpName = txtEmpLoginName.Text;
            employee.Pwd = EncryptHelper.MD5Encrypt(txtEmpLoginPwd.Text.Trim());//加密
          
            employee.Sex = cbxsex.Text;
            employee.BirthDay = daEmpBirthday.Value;
            employee.DepId = Convert.ToInt32(cmbEmpDept.SelectedValue);
            switch (Convert.ToInt32(cmbEmpDept.SelectedValue))
            {
                case 1: //管理部
                    employee.Role = 2;
                    break;
                case 2:
                    //采购部
                    employee.Role = 3;
                    break;
                case 3:
                    //销售部
                    employee.Role = 4;
                    break;

                default:
                    break;
            }

            employee.Phone = txtEmpPhone.Text;
            employee.Address = txtAddress.Text;
            //if (intFalg != 3)
            //{
            //    EmpClass.intEmpFalg = 0;
            //}
            //else
            //{
            //    EmpClass.intEmpFalg = 1;
            //}
            intFalg1 = 1;
            return intFalg1;
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getPan() == 1)
            {
                if (intFalg == 1)
                { //添加
                    if (EmployeeDAL.checkloginName(employee.EmpName))
                    {
                        MessageBox.Show("登录名称已被占用！");
                        txtEmpLoginName.Text = "";
                        txtEmpLoginName.Focus();
                        return;
                    }
                    employee.CreateTime = DateTime.Now;
                    employee.UpdateTime = DateTime.Now;
                    employee.Email = "";
                    employee.Remark = "";
                    if (EmployeeDAL.add(employee) > 0)
                    {
                        MessageBox.Show("新增成功");
                    }
                    else 
                    {
                        MessageBox.Show("新增失败");
                    }
                    
                    intFalg = 0;
                    BindData("", 0);
                    ClearControls();
                    ControlStatus(); ;

                }
                if (intFalg == 2)
                {
                    //修改
                    Employee model = EmployeeDAL.getEntryById<Employee, long>(employee.EmpId);
                    if (model == null)
                    {
                        MessageBox.Show("账号不存在，修改失败");
                        intFalg = 0;
                        ClearControls();
                        ControlStatus();

                    }
                    else
                    {
                        employee.Pwd = model.Pwd;//密码不更改
                        EmployeeDAL.EditEntry<Employee>(employee, "EmpId");
                       // UsersDAL.EditEntry<Users>(user, "UserId");

                        MessageBox.Show("修改成功");
                        intFalg = 0;
                        BindData("", 0);
                        ClearControls();
                        ControlStatus();

                    }


                }
                if (intFalg == 3)
                {
                    Employee model = EmployeeDAL.getEntryById<Employee, long>(employee.EmpId);

                    //删除
                    if (model != null)
                    {
                        EmployeeDAL.DeleteEntry<Employee, int>(employee.EmpId);
                        MessageBox.Show("删除成功");
                        BindData("", 0);
                        intFalg = 0;

                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                        intFalg = 0;
                        ClearControls();
                        ControlStatus();
                    }
                }
            }
        }
        //添加
        private void toolAdd_Click(object sender, EventArgs e)
        {

            ClearControls();//清空控件内容
            ControlStatus();//控件控制状态
            intFalg = 1;//添加标
        }
        //修改
        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 2; //修改标记
        }
        //删除
        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 3; //删除标记
        }
        //退出
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();//清空控件内容
            ControlStatus();//控件控制状态
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (intFalg == 2 || intFalg == 3 )
            {
                FillControls();
            }
            else if (intFalg == 5) 
            {
                try
                {
                    int empId = Convert.ToInt32(this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString());
                    if (empId == 0)
                    {
                        MessageBox.Show("请选择一个要重置密码的用户");
                    }
                    else
                    {
                        Employee model = EmployeeDAL.getEntryById<Employee, long>(empId);
                        model.Pwd = EncryptHelper.MD5Encrypt("123456");//加密
                        EmployeeDAL.EditEntry<Employee>(model, "EmpId");
                        MessageBox.Show("用户名为：" + model.EmpName + " 的用户密码已重置为123456");
                        intFalg = 0;
                    }
                }
                catch (Exception)
                {
                    intFalg = 0;
                 
                }
              
            }
        }
        public void FillControls()
        {
            try
            {
                if (dgvlist.Rows.Count > 0)
                {
                    List<Dept> deptlist = DeptDAL.getlist();

                    int empId = Convert.ToInt32(this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString());
                    Dept dept = deptlist.Find(x => x.EmpId == empId);
                    Employee model = EmployeeDAL.getEntryById<Employee, long>(empId);
                    txtEmpName.Text = model.RealName.ToString();
                    txtEmpLoginName.Text = string.IsNullOrEmpty(model.EmpName) ? "" : model.EmpName.ToString();
                    cbxsex.Text = model.Sex.ToString();
                    daEmpBirthday.Value = model.BirthDay;
                    cmbEmpDept.Text = deptlist.Find(x => x.DeptId == model.DepId).DeptName.ToString();
                    cmbEmpPost.Text = dept == null ? "员工" : "组长";
                    txtEmpPhone.Text = string.IsNullOrEmpty(model.Phone) ? "" : model.Phone.ToString();
                    txtAddress.Text = string.IsNullOrEmpty(model.Address) ? "" : model.Address.ToString();
                    txtEmpLoginPwd.Text = "******";
                    txtEmpLoginPwd.Enabled = false;//禁止改密码
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void tsClearPwd_Click(object sender, EventArgs e)
        {
            intFalg = 5;
        }
    }
}
