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

namespace LYH_JXC.GoodsOut
{
    public partial class FrmReturngoods : BaseForm
    {
        public FrmReturngoods()
        {
            InitializeComponent();
            BindDrop();
            BinddgvData();
            txtdeSellPrice.Enabled = false;
        }
        public int MaxNum = 0;
        Dictionary<int, Goods> diclist = new Dictionary<int, Goods>();
        public Dictionary<int, Dic> dickeys = new Dictionary<int, Dic>();
        public int goodsId = 0; //商品编号
        public int unitId = 0;  //计量单位编号
        private DateTime addtime;
        public static int intFalg = 0; //操作类型（增删改查 ）
        Sales sales = new Sales();
        private void ClearControl()
        {
            txtSellGoodsNum.Text = "";


            txtGoodsName.Text = "";
            txtdeSellPrice.Text = "";



        }
        private void ControlStaus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
        }

        private void BindDrop()
        {
            int total = 0;

           
            List<Goods> goodslist = GoodsDAL.Getlist("", 0, out total);
            if (goodslist.Count > 0)
            {
                diclist = goodslist.ToDictionary(x => x.GoodsId);
            }
            List<Dic> dickeylist = DicDAL.Getlist("", 0, out total);
            if (dickeylist != null && dickeylist.Count > 0)
            {
                dickeys = dickeylist.ToDictionary(x => x.KeyId);
            }
        }

        private void BinddgvData()
        {
            List<Sales> list = SalesDAL.Getlist(currentUser.EmpId);
           
            if (list != null && list.Count > 0)
            { 
                //筛选出7天内的数据
                list = list.Where(x => x.AddTime >= DateTime.Now.AddDays(-7)).ToList();
                //筛选后判断
                if (list.Count > 0) 
                {
                    dgvlist.RowCount = list.Count;
                    for (int i = 0; i < list.Count; i++)
                    {


                        dgvlist[0, i].Value = diclist.ContainsKey(list[i].GoodsId) ? diclist[list[i].GoodsId].GoodsName.ToString() : "";
                        dgvlist[1, i].Value = list[i].Price;
                        dgvlist[2, i].Value = string.IsNullOrEmpty(list[i].Num.ToString()) ? "" : list[i].Num.ToString() + dickeys[diclist[list[i].GoodsId].KeyUnitId].KeyName;
                        dgvlist[3, i].Value = string.IsNullOrEmpty(currentUser.RealName.ToString()) ? "" : currentUser.RealName.ToString();
                        dgvlist[4, i].Value = string.IsNullOrEmpty(list[i].AddTime.ToString()) ? "" : list[i].AddTime.ToString();
                    }
                }
                

            }
            else
            {
                dgvlist.Rows.Clear();
            }


        }

        private void txtdeSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtSellGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
            else 
            {
                if (MaxNum>0 && Convert.ToInt32(txtSellGoodsNum.Text.Trim()) > MaxNum) 
                {
                    MessageBox.Show("退货数量不能超过原纪录");
                    txtSellGoodsNum.Text = "";
                    e.Handled = true;
                }
            }
        }


        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStaus();
            ClearControl();
            intFalg = 1; //添加标签
            //txtGoodsID.Text = jhMenthod.JhGoodsID();
            txtGoodsName.Enabled = false;
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
        public void FillControls()
        {
            try
            {
                if (dgvlist.Rows.Count > 0)
                {
                    addtime = Convert.ToDateTime(this.dgvlist[4, this.dgvlist.CurrentCell.RowIndex].Value.ToString());

                    Sales model = SalesDAL.getEntryById<Sales, DateTime>(addtime);
                    txtGoodsName.Text = diclist.ContainsKey(model.GoodsId) ? diclist[model.GoodsId].GoodsName.ToString() : "";
                    goodsId = model.GoodsId;
                    txtdeSellPrice.Text = model.Price.ToString();
                    txtSellGoodsNum.Text = model.Num.ToString();
                }

            }
            catch (Exception ee)
            {
               
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getIntCount() == 1)
            {
                if (intFalg == 1)
                {
                    try
                    {

                        //退货
                        Sales model = SalesDAL.getEntryById<Sales, DateTime>(addtime);
                        if (model == null)
                        {
                            MessageBox.Show("记录不存在", "提示");
                        }
                        else if (model.Num - sales.Num < 0) 
                        {
                            MessageBox.Show("退货数量超出销售数量", "提示");
                        }
                        else if (model.Num - sales.Num == 0)
                        {
                            //退货数量和销售数量一致，删除该销售记录
                            SalesDAL.DeleteEntry<Sales,DateTime>(model.AddTime);
                            LogInfoDAL.add(new LogInfo(0, 2, currentUser.EmpId, 3, model.Num, DateTime.Now));
                            MessageBox.Show("退货成功", "提示");
                            BinddgvData();
                        }
                        else
                        {


                            sales.Num = (model.Num - sales.Num);
                            SalesDAL.EditEntry<Sales>(sales, "AddTime");
                            LogInfoDAL.add(new LogInfo(0, 2, currentUser.EmpId, 2, (model.Num - sales.Num), DateTime.Now));
                            MessageBox.Show("退货成功", "提示");
                            BinddgvData();


                        }
                        intFalg = 0;
                        ClearControl();
                        ControlStaus();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("退货失败，" + ex.Message, "提示");
                    }


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
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空！");
                    return intReslut;
                }

                if (txtdeSellPrice.Text == "")
                {
                    MessageBox.Show("销售单价不能为空！");
                    return intReslut;
                }
                if (txtSellGoodsNum.Text == "")
                {
                    MessageBox.Show("销售数量不能为空！");
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
            sales.GoodsId = goodsId;
            sales.Num = Convert.ToInt32(this.txtSellGoodsNum.Text.Trim());
            sales.Price = Convert.ToDecimal(this.txtdeSellPrice.Text.Trim());
            sales.AddTime = addtime;
            sales.EmpId = currentUser.EmpId;
            intReslut = 1;
            return intReslut;
        }

        private void dgvlist_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FillControls();
        }
    }
}
