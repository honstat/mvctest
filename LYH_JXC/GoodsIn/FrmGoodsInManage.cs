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
namespace LYH_JXC.GoodsIn
{
    public partial class FrmGoodsInManage : BaseForm
    {
        int total = 0;
        public int goodsId = 0;
        public int unitId = 0;
        Dictionary<int, Goods> diclist = new Dictionary<int, Goods>();
        Dictionary<int, Ware> warelist = new Dictionary<int, Ware>();
        public Dictionary<int, Dic> dickeys = new Dictionary<int, Dic>();
        private DateTime addtime;
        public FrmGoodsInManage()
        {
            InitializeComponent();
            BindDrop();
            initKeylist();
            BinddgvData();
        }
        private void initKeylist()
        {

            List<Dic> dickeylist = DicDAL.Getlist("", 0, out total);
            if (dickeylist != null && dickeylist.Count > 0)
            {
                dickeys = dickeylist.ToDictionary(x => x.KeyId);
            }

            List<Goods> goodslist = GoodsDAL.Getlist("", 0, out total);
            if (goodslist.Count > 0)
            {
                diclist = goodslist.ToDictionary(x => x.GoodsId);
            }

            List<Ware> wlist = WareDAL.Getlist();
            if (wlist.Count > 0)
            {
                warelist = wlist.ToDictionary(x => x.WareId);
            }
        }
        private void BinddgvData()
        {
            List<Stock> list = StockDAL.Getlist("采购部", 4, out total);
            list = list.Where(l => l.EmpId == currentUser.EmpId).ToList();
            if (list != null && list.Count > 0)
            {
                dgvlist.RowCount = list.Count;
                for (int i = 0; i < list.Count; i++)
                {

                    dgvlist[0, i].Value = list[i].GoodsId.ToString();
                    dgvlist[1, i].Value = diclist.ContainsKey(list[i].GoodsId) ? diclist[list[i].GoodsId].GoodsName.ToString() : "";
                    dgvlist[2, i].Value = warelist.ContainsKey(list[i].WareId) ? warelist[list[i].WareId].Name.ToString() : "";
                    dgvlist[3, i].Value = string.IsNullOrEmpty(list[i].Num.ToString()) ? "" : list[i].Num.ToString() + dickeys[diclist[list[i].GoodsId].KeyUnitId].KeyName;
                    dgvlist[4, i].Value = string.IsNullOrEmpty(list[i].Price.ToString()) ? "" : list[i].Price.ToString();
                    dgvlist[5, i].Value = string.IsNullOrEmpty(list[i].AddTime.ToString()) ? "" : list[i].AddTime.ToString();
                }

            }
            else
            {
                dgvlist.Rows.Clear();
            }


        }

        private void BindDrop()
        {
            int total = 0;

            List<Employee> list = EmployeeDAL.Getlist("采购部", 4, out total);
            list = list.Where(l => l.DepId == 2).ToList();
            if (list != null && list.Count > 0)
            {
                cbxemployee.DataSource = list;
                cbxemployee.DisplayMember = "EmpName";
                cbxemployee.ValueMember = "EmpId";
            }

            //List<Dic> diclist = DicDAL.Getlist("", 0, out total);

            //if (diclist != null && diclist.Count > 0)
            //{
            //    this.cbxgoodsunit.DataSource = diclist;
            //    cbxgoodsunit.DisplayMember = "KeyName";
            //    cbxgoodsunit.ValueMember = "KeyId";
            //}
            List<Ware> warelist = WareDAL.Getlist();
            if (warelist != null && warelist.Count > 0)
            {
                this.cmbDepotName.DataSource = warelist;
                cmbDepotName.DisplayMember = "Name";
                cmbDepotName.ValueMember = "WareId";
            }
        }
        Goods jhGood = new Goods();
        Stock stock = new Stock();

        public static int intFalg = 0;
        private void ClearControl()
        {
            txtGoodsNum.Text = "";


            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";


            cmbDepotName.Text = "";
        }
        private void ControlStaus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.tollDelete.Enabled = !this.tollDelete.Enabled;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStaus();
            ClearControl();
            intFalg = 1; //添加标签
            //txtGoodsID.Text = jhMenthod.JhGoodsID();
            txtGoodsName.Enabled = false;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStaus();
            ClearControl();
            intFalg = 2; //修改标签
        }

        private void tollDelete_Click(object sender, EventArgs e)
        {
            ControlStaus();
            ClearControl();
            intFalg = 3; //修改标签
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStaus();
            ClearControl();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getIntCount() == 1)
            {
                if (intFalg == 1)
                {
                    try
                    {

                        if (StockDAL.add(stock))
                        {
                            LogInfoDAL.add(new LogInfo(0, 1, currentUser.EmpId, 1, stock.Num, stock.AddTime));
                            MessageBox.Show("添加成功", "提示");
                            BinddgvData();
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "提示");
                        }


                        intFalg = 0;

                        ClearControl();
                        ControlStaus();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("添加失败，" + ex.Message, "提示");
                    }


                }
                if (intFalg == 2)
                {
                    //修改
                    Stock model = StockDAL.getEntryById<Stock, DateTime>(stock.AddTime);
                    if (model == null)
                    {
                        MessageBox.Show("记录不存在", "提示");
                    }
                    else
                    {
                        stock.AddTime = model.AddTime;
                        StockDAL.EditEntry<Stock>(stock, "AddTime");
                        LogInfoDAL.add(new LogInfo(0, 1, currentUser.EmpId, 2, stock.Num - model.Num, DateTime.Now));
                        MessageBox.Show("修改成功", "提示");
                        BinddgvData();
                    }
                    intFalg = 0;
                    ClearControl();
                    ControlStaus();

                }
                if (intFalg == 3)
                {
                    Stock model = StockDAL.getEntryById<Stock, DateTime>(stock.AddTime);
                    if (model == null)
                    {
                        MessageBox.Show("记录不存在", "提示");
                    }
                    else
                    {
                        if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                        { 

                            LogInfoDAL.add(new LogInfo(0, 1, currentUser.EmpId, 3, model.Num, DateTime.Now));
                            StockDAL.DeleteEntry<Stock, DateTime>(model.AddTime);
                            MessageBox.Show("删除成功", "提示");
                            BinddgvData();
                        }
                      
                    }

                    intFalg = 0;
                    ClearControl();
                    ControlStaus();
                }
            }
        }

        public int getIntCount()
        {
            int intReslut = 0;
            if (intFalg == 1)
            {
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空!");
                    return intReslut;
                }
               
                if (this.cbxemployee.Text == "")
                {
                    MessageBox.Show("进货人姓名不能为空！");
                    return intReslut;
                }
                if (txtGoodsNum.Text == "")
                {
                    MessageBox.Show("进货数量不能为空！");
                    return intReslut;
                }

                if (cmbDepotName.Text == "")
                {
                    MessageBox.Show("仓库不能为空！");
                    return intReslut;
                }
            }
            if (intFalg == 2)
            {
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空!,选择要修改的记录", "提示");
                    return intReslut;
                }

            }
            if (intFalg == 3)
            {
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空！,选择要删除记录", "提示");
                    return intReslut;
                }
            }
            stock.GoodsId = goodsId;
            stock.Num = Convert.ToInt32(txtGoodsNum.Text.Trim());
            stock.Price = Convert.ToDecimal(txtGoodsJhPrice.Text.Trim());
            stock.WareId = Convert.ToInt32(cmbDepotName.SelectedValue);
            stock.AddTime = dateTimePickerdate.Value.DayOfYear == DateTime.Now.DayOfYear ? DateTime.Now : dateTimePickerdate.Value;
            stock.EmpId = Convert.ToInt32(cbxemployee.SelectedValue);
            intReslut = 1;
            return intReslut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSupplierManage frmsup = new FrmSupplierManage();
            frmsup.Owner = this;
            frmsup.ShowDialog();
        }

        private void txtGoodsJhPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtGoodsNoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtGoodsSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }


        public void FillControls()
        {
            try
            {
                if (dgvlist.Rows.Count > 0)
                {
                    addtime = Convert.ToDateTime(this.dgvlist[5, this.dgvlist.CurrentCell.RowIndex].Value.ToString());

                    Stock model = StockDAL.getEntryById<Stock, DateTime>(addtime);
                    txtGoodsName.Text = diclist.ContainsKey(model.GoodsId) ? diclist[model.GoodsId].GoodsName.ToString() : "";
                    goodsId = model.GoodsId;
                    txtGoodsJhPrice.Text = model.Price.ToString();
                    txtGoodsNum.Text = model.Num.ToString();
                    dateTimePickerdate.Value = model.AddTime;
                    dateTimePickerdate.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
        }

        private void btnGoodSelect_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGoodsInfo frm = new FrmGoodsInfo();
                frm.Owner = this;
                frm.opertype = 1;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillControls();
        }


    }
}
