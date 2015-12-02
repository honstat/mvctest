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

namespace LYH_JXC.StockManage
{
    public partial class FrmStockQuery : Form
    {
        Dictionary<string, Goods> diclist = new Dictionary<string, Goods>();
        Dictionary<int, Goods> dicIdlist = new Dictionary<int, Goods>();
        public FrmStockQuery()
        {
            InitializeComponent();
            initdata();
            cbxQueryType.SelectedIndex = 0;
            query();
          
        }
        private void initdata()
        {
            int total = 0;
            List<Goods> goodslist = GoodsDAL.Getlist("", 0, out total);
            if (goodslist.Count > 0)
            {
                diclist = goodslist.ToDictionary(x => x.GoodsName);
                dicIdlist = goodslist.ToDictionary(x => x.GoodsId);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query();
        }

        private void cbxQueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkeyword.Text = "";//清空
          
        }
        private void query() 
        {
            string keyword = this.txtkeyword.Text.Trim();
            List<StcokQueryty> stocklist = null;
            try
            {
                switch (this.cbxQueryType.Text.Trim())
                {
                    case "商品编号":
                        stocklist = StockDAL.GetStocklist(keyword, 1);
                        break;
                    case "商品名称":
                        if (!diclist.ContainsKey(keyword))
                        {
                            MessageBox.Show("没有找到该名称的商品");
                        }
                        else
                        {
                            stocklist = StockDAL.GetStocklist(diclist[this.txtkeyword.Text.Trim()].GoodsId.ToString(), 2);
                        }

                        break;
                    case "库存数量":
                        stocklist = StockDAL.GetStocklist(keyword, 3);
                        if (stocklist != null && stocklist.Count > 0) 
                        {
                           stocklist = stocklist.Where(x => x.Num == Convert.ToInt32(keyword)).ToList();
                        }
                        break;
                    case "警报数量":
                        var list = diclist.Where(a => a.Value.WarnNum == Convert.ToInt32(keyword)).ToList();
                        if (list != null && list.Count > 0)
                        {
                            string str = string.Empty;
                            foreach (var item in list)
                            {
                                str += item.Value.GoodsId + ",";
                            }
                            stocklist = StockDAL.GetStocklist(str.TrimEnd(',').ToString(), 4);
                        }
                        else
                        {
                            MessageBox.Show("找不到预警数量为" + keyword + "的商品");
                        }

                        break;
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            BinddgvData(stocklist);
        }

        private void txtkeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (this.cbxQueryType.Text.Trim())
            {
                case "商品编号":
                    if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                        MessageBox.Show("请输入数字");
                        e.Handled = true;
                    }
                    break;
               
                case "库存数量":
                    if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                        MessageBox.Show("请输入数字");
                        e.Handled = true;
                    }
                    break;
            }
        }
        private void BinddgvData(List<StcokQueryty> list)
        {
          
            if (list != null && list.Count > 0)
            {
                dgvlist.RowCount = list.Count;
                for (int i = 0; i < list.Count; i++)
                {


                    dgvlist[0, i].Value = list[i].GoodsId;
                    dgvlist[1, i].Value = dicIdlist.ContainsKey(list[i].GoodsId) ? dicIdlist[list[i].GoodsId].GoodsName.ToString() : "";
                    dgvlist[2, i].Value = string.IsNullOrEmpty(list[i].Num.ToString()) ? "" : list[i].Num.ToString();
                    dgvlist[3, i].Value = dicIdlist.ContainsKey(list[i].GoodsId) ? dicIdlist[list[i].GoodsId].WarnNum.ToString() : "";
                   
                }

            }
            else
            {
                dgvlist.Rows.Clear();
            }


        }
    }
}
