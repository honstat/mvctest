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
using LYH_JXC.DAL;
using LYH_JXC.Entity;
namespace LYH_JXC.Users
{
    public partial class FrmCompanyInfo : Form
    {
        public FrmCompanyInfo()
        {
            InitializeComponent();
        }

        private void FrmCompanyInfo_Load(object sender, EventArgs e)
        {
            BindData("", 0);
        }
        public static int intFalg = 0;//控件方法状态      
        Supplier supplier = new Supplier();
        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            txtCompanyDirector.Text = "";
            txtCompanyAddress.Text = "";
            txtTel.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyRemark.Text = "";
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
                List<Supplier> list = SupplierDAL.Getlist(txtStr, intFalg, out total);
                if (list != null && list.Count > 0)
                {
                    dgvlist.RowCount = list.Count;
                    for (int i = 0; i < list.Count; i++)
                    {

                        dgvlist[0, i].Value = list[i].SupplierId.ToString();
                        dgvlist[1, i].Value = list[i].Name.ToString();
                        dgvlist[2, i].Value = string.IsNullOrEmpty(list[i].Director) ? "" : list[i].Director.ToString();
                        dgvlist[3, i].Value = string.IsNullOrEmpty(list[i].Phone) ? "" : list[i].Phone.ToString();
                        dgvlist[4, i].Value = string.IsNullOrEmpty(list[i].Address) ? "" : list[i].Address.ToString();
                        dgvlist[5, i].Value = string.IsNullOrEmpty(list[i].Tel) ? "" : list[i].Tel.ToString();
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


                case "供应商名称":
                    flag = 1;
                    break;
                case "负责人姓名":
                    flag = 2;
                    break;

                default:
                    break;
            }
            //获取查询条件并查询
            BindData(txtKeyWord.Text.Trim(), flag);
        }
        public int getPan()
        {
            int intResult = 0;
            if (intFalg == 1 || intFalg == 2)
            {

                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("供应商姓名不能为空", "提示");
                    return intResult;
                }
                if (txtCompanyPhone.Text == "")
                {
                    MessageBox.Show("联系电话不能为空", "提示");
                    return intResult;
                }
                if (txtCompanyDirector.Text == "")
                {
                    MessageBox.Show("负责人姓名不能为空", "提示");
                    return intResult;
                }
                if (intFalg != 2)
                {
                    supplier.SupplierId = 0;
                }
                else
                {
                    supplier.SupplierId = Convert.ToInt32(this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString());
                }

                supplier.Name = txtCompanyName.Text.Trim();
                supplier.Phone = txtCompanyPhone.Text.Trim();
                supplier.Address = txtCompanyAddress.Text.Trim();
                supplier.Remark = txtCompanyRemark.Text.Trim().Length > 50 ? txtCompanyRemark.Text.Trim().Substring(0, 50) : txtCompanyRemark.Text.Trim();
                supplier.Director = txtCompanyDirector.Text.Trim();
                supplier.Tel = txtTel.Text.Trim();
            }
            if (intFalg == 3)
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("供应商姓名不能为空!请选择要删除的记录", "提示");
                    return intResult;
                }

                supplier.SupplierId = Convert.ToInt32(this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString());
            }
            intResult = 1;
            return intResult;
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getPan() == 1)
            {
                if (intFalg == 1)
                { //添加
                    if (SupplierDAL.checkloginName(supplier.Name))
                    {
                        MessageBox.Show("登录名称已被占用！");
                        this.txtCompanyName.Text = "";
                        txtCompanyName.Focus();
                        return;
                    }
                    SupplierDAL.AddModel<Supplier>(supplier);

                    intFalg = 0;
                    BindData("", 0);
                    ClearControls();
                    ControlStatus(); ;

                }
                if (intFalg == 2)
                {
                    //修改
                    Supplier model = SupplierDAL.getEntryById<Supplier, long>(supplier.SupplierId);
                    if (model == null)
                    {
                        MessageBox.Show("账号不存在，修改失败");
                        intFalg = 0;
                        ClearControls();
                        ControlStatus();

                    }
                    else
                    {
                        if (SupplierDAL.checkloginName(supplier.Name, supplier.SupplierId))
                        {
                            MessageBox.Show("供应商名称已存在");

                        }
                        else
                        {
                            SupplierDAL.EditEntry<Supplier>(supplier, "SupplierId");
                            MessageBox.Show("修改成功");
                            BindData("", 0);

                        }
                        ClearControls();
                        ControlStatus();

                    }


                }
                if (intFalg == 3)
                {
                    Supplier model = SupplierDAL.getEntryById<Supplier, long>(supplier.SupplierId);

                    //删除
                    if (model != null)
                    {
                        SupplierDAL.DeleteEntry<Supplier, int>(supplier.SupplierId);
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
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
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
                    Supplier model = EmployeeDAL.getEntryById<Supplier, long>(empId);
                    this.txtCompanyName.Text = model.Name.ToString();
                    txtCompanyDirector.Text = string.IsNullOrEmpty(model.Director) ? "" : model.Director.ToString();
                    txtCompanyAddress.Text = string.IsNullOrEmpty(model.Address) ? "" : model.Address.ToString();
                    txtTel.Text = string.IsNullOrEmpty(model.Tel) ? "" : model.Tel.ToString();
                    txtCompanyPhone.Text = string.IsNullOrEmpty(model.Phone) ? "" : model.Phone.ToString();
                    txtCompanyRemark.Text = string.IsNullOrEmpty(model.Remark) ? "" : model.Remark.ToString();

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void toolExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
