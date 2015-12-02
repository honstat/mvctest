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
using LYH_JXC.GoodsOut;
using LYH_JXC.StockManage;
namespace LYH_JXC.GoodsIn
{
    public partial class FrmGoodsInfo : Form
    {
        public int opertype = 0; //操作的界面标识
        public FrmGoodsInfo()
        {
            InitializeComponent();
            binddata();
        }
    
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode.Text != "")
            {
                if (opertype == 1)
                {
                    //进货界面
                    FrmGoodsInManage frm = (FrmGoodsInManage)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;
                    frm.goodsId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.unitId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[1]);
                    frm.lblUnitName.Text = frm.dickeys[frm.unitId].KeyName;
                    this.Close();
                }
                else if (opertype == 2)
                {
                    FrmGoodsSales frm = (FrmGoodsSales)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;
                    frm.goodsId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.unitId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[1]);
                    frm.lblUnitName.Text = frm.dickeys[frm.unitId].KeyName;
                    this.Close();
                }
                else if (opertype == 3)
                {
                    FrmStockWarn frm = (FrmStockWarn)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;

                    frm.goodId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.txtWarnNum.Text = tv.SelectedNode.Tag.ToString().Split(',')[2];
                    this.Close();
                }
             

            }
            else
            {
                MessageBox.Show("请选择商品信息");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void binddata()
        {
            tv.Nodes.Clear();

            tv.ImageList = this.imglist;
            System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("商品名称", 0, 1);

            int total = 0;
            List<Goods> list = GoodsDAL.Getlist("", 0, out total);
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                   
                    TreeNode tr = new TreeNode();
                    tr.Name = "";
                    tr.Text = item.GoodsName.ToString();
                    tr.Tag = item.GoodsId.ToString()+","+item.KeyUnitId+","+item.WarnNum;
                    tr.ImageIndex = 0;
                    tr.SelectedImageIndex = 1;
                    TN.Nodes.Add(tr);
                }

            }




            tv.Nodes.Add(TN);

            tv.ExpandAll();
        }

        private void FrmGoodsInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void tv_DoubleClick(object sender, EventArgs e)
        {
            if (tv.SelectedNode.Text != "")
            {
                if (opertype == 1)
                {
                    //进货界面
                    FrmGoodsInManage frm = (FrmGoodsInManage)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;
                    frm.goodsId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.unitId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[1]);
                    frm.lblUnitName.Text = frm.dickeys[frm.unitId].KeyName;
                    this.Close();
                }
                else if (opertype == 2)
                {
                    FrmGoodsSales frm = (FrmGoodsSales)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;
                    frm.goodsId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.unitId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[1]);
                    frm.lblUnitName.Text = frm.dickeys[frm.unitId].KeyName;
                    this.Close();
                }
                else if (opertype == 3)
                {
                    FrmStockWarn frm = (FrmStockWarn)this.Owner;
                    frm.txtGoodsName.Text = tv.SelectedNode.Text;
                    frm.txtGoodsName.Enabled = false;
                   
                    frm.goodId = Convert.ToInt32(tv.SelectedNode.Tag.ToString().Split(',')[0]);
                    frm.txtWarnNum.Text = tv.SelectedNode.Tag.ToString().Split(',')[2];
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("选择供应商信息");
            }
        }
    }
}
