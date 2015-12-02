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
    public partial class FrmSalesList : BaseForm
    {
        Dictionary<int, Goods> diclist = new Dictionary<int, Goods>();
        public Dictionary<int, Dic> dickeys = new Dictionary<int, Dic>();
        public FrmSalesList()
        {
            InitializeComponent();
            initdata();
            BinddgvData();
        }
        private void initdata() 
        {
            int total = 0;


            List<Goods> goodslist = GoodsDAL.Getlist("", 0, out total);
            if (goodslist.Count > 0)
            {
                diclist = goodslist.ToDictionary(x => x.GoodsId);
            }

        }
        private void BinddgvData()
        {
            List<Sales> list = SalesDAL.Getlist(currentUser.EmpId);
            if (list != null && list.Count > 0)
            {
                dgvlist.RowCount = list.Count;
                for (int i = 0; i < list.Count; i++)
                {


                    dgvlist[0, i].Value = list[i].GoodsId;
                    dgvlist[1, i].Value = diclist.ContainsKey(list[i].GoodsId) ? diclist[list[i].GoodsId].GoodsName.ToString() : "";
                    dgvlist[2, i].Value = list[i].Price;
                    dgvlist[3, i].Value = string.IsNullOrEmpty(list[i].Num.ToString()) ? "" : list[i].Num.ToString();
                    dgvlist[4, i].Value = string.IsNullOrEmpty(list[i].AddTime.ToString()) ? "" : list[i].AddTime.ToString();
                }

            }
            else
            {
                dgvlist.Rows.Clear();
            }


        }

        private void dgvlist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvlist.Rows.Count > 0) 
                {
                    DateTime addtime = Convert.ToDateTime(this.dgvlist[4, this.dgvlist.CurrentCell.RowIndex].Value.ToString());

                    Sales model = SalesDAL.getEntryById<Sales, DateTime>(addtime);
                    //进货界面
                    FrmReturngoods frm = (FrmReturngoods)this.Owner;
                    frm.txtGoodsName.Text = diclist[model.GoodsId].GoodsName;
                    frm.txtSellGoodsNum.Text = model.Num.ToString();
                    frm.txtdeSellPrice.Text = model.Price.ToString();
                    frm.MaxNum = model.Num;
                    this.Close();
                }
               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }


    }
}
