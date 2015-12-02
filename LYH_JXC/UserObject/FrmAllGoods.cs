using LYH_JXC.DAL;
using LYH_JXC.Entity;
using LYH_JXC.GoodsIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC.UserObject
{
    public partial class FrmAllGoods : Form
    {
        Dictionary<int, Dic> diclist = new Dictionary<int, Dic>();
        Dictionary<int, Goods> dicIdlist = new Dictionary<int, Goods>();
        Dictionary<int, Supplier> suplierIdlist = new Dictionary<int, Supplier>();
        public FrmAllGoods()
        {
            InitializeComponent();
            initdata();
            BinddgvData();
        }
        private void initdata()
        {
            int total = 0;
           
            List<Dic> dicslist = DicDAL.Getlist("", 0, out total);
            if (dicslist.Count > 0)
            {
                diclist = dicslist.ToDictionary(x => x.KeyId);
            }
            List<Supplier> suplist = SupplierDAL.Getlist("", 4,out total);
            if (suplist != null && suplist.Count > 0) 
            {
                suplierIdlist = suplist.ToDictionary(x => x.SupplierId);
            }

        }
        public void BinddgvData()
        {
            int total = 0;
            List<Goods> goodslist = GoodsDAL.Getlist("", 0, out total);
            if (goodslist.Count > 0)
            {
                dicIdlist = goodslist.ToDictionary(x => x.GoodsId);
            }
            if (goodslist != null && goodslist.Count > 0)
            {
                dgvlist.RowCount = goodslist.Count;
                for (int i = 0; i < goodslist.Count; i++)
                {
                    dgvlist[0, i].Value = goodslist[i].GoodsId;
                    dgvlist[1, i].Value = dicIdlist[goodslist[i].GoodsId].GoodsName;
                    dgvlist[2, i].Value = diclist.ContainsKey(goodslist[i].KeyBrandId) ? diclist[goodslist[i].KeyBrandId].KeyName.ToString() : "";
                    dgvlist[3, i].Value = diclist.ContainsKey(goodslist[i].KeyTypeId) ? diclist[goodslist[i].KeyTypeId].KeyType.ToString() : "";
                    dgvlist[4, i].Value = diclist.ContainsKey(goodslist[i].KeyUnitId) ? diclist[goodslist[i].KeyUnitId].KeyName.ToString() : "";
                    dgvlist[5, i].Value = suplierIdlist.ContainsKey(goodslist[i].SupplierId) ? suplierIdlist[goodslist[i].SupplierId].Name.ToString() : "";
                    dgvlist[6, i].Value = goodslist[i].WarnNum;
                }

            }
            else
            {
                dgvlist.Rows.Clear();
            }


        }
        private void tsDelete_Click(object sender, EventArgs e)
        {
           int id= getgoodid();
           if (MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
           {
               Goods model = GoodsDAL.getEntryById<Goods, long>(id);
               if (model != null)
               {
                  List<Stock> stocklist= StockDAL.Getlist("",20,out id);
                  if (stocklist != null && stocklist.Where(x => x.GoodsId == model.GoodsId).Count() > 0)
                  {
                      MessageBox.Show("库存中还有该商品,不能删除");
                      return;
                  }
                  else
                  {
                      GoodsDAL.DeleteEntry<Goods, long>(model.GoodsId);
                      MessageBox.Show("删除成功");
                      BinddgvData();
                  }
                 
                 
               }
           }
        
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            int id = getgoodid();
            FrmGoodsInsert frm = new FrmGoodsInsert(id);
            frm.Owner = this;
            frm.ShowDialog();
        }


        private int getgoodid() 
        {
            try
            {
                if (dgvlist.Rows.Count > 1)
                {
                    return  Convert.ToInt32(this.dgvlist[0, this.dgvlist.CurrentCell.RowIndex].Value.ToString());

                   
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            return 0;
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            FrmGoodsInsert frm = new FrmGoodsInsert();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dgvlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = getgoodid();
            new FrmGoodsInsert(id).ShowDialog();
        }
    }
}
