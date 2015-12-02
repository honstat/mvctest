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
    public partial class FrmSupplierManage : Form
    {
        public FrmSupplierManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode.Text != "")
            {
                FrmGoodsInManage jhGood = (FrmGoodsInManage)this.Owner;
                //jhGood.txtJhCompName.Text = tv.SelectedNode.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("选择供应商信息");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSupplierManage_Load(object sender, EventArgs e)
        {

        }
        private void binddata() 
        {
            

           
            tv.Nodes.Clear();

            tv.ImageList = this.imglist;
            System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("供应商名称", 0, 1);
           
            int total=0;
           List<Supplier>list = SupplierDAL.Getlist("", 0, out total);
           if (list != null && list.Count > 0)
           {
               foreach (var item in list)
               {
                   TN.Nodes.Add("", item.Name.ToString(), 0, 1);
               }
              
           }

             

  
            tv.Nodes.Add(TN);
           
            tv.ExpandAll();
        }
    }
}
