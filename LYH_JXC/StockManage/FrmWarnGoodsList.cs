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
    public partial class FrmWarnGoodsList : Form
    {
        Dictionary<int, Goods> diclist = new Dictionary<int, Goods>();
        List<WarnLog> list = null;
        public FrmWarnGoodsList()
        {
            InitializeComponent();
            initdata();
            getlist();
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
        private void getlist() {
         list = WarnLogDAL.getlist();
         if (list.Count > 0) 
         {
             list = list.Where(x => x.IsRead == false).ToList();
             if (list != null && list.Count > 0)
             {
                 dgvlist.RowCount = list.Count;
                 for (int i = 0; i < list.Count; i++)
                 {
                     dgvlist[0, i].Value = list[i].GoodsId;
                     dgvlist[1, i].Value = diclist.ContainsKey(list[i].GoodsId) ? diclist[list[i].GoodsId].GoodsName.ToString() : "";
                     dgvlist[2, i].Value = string.IsNullOrEmpty(list[i].OnlyNum.ToString()) ? "" : list[i].OnlyNum.ToString();
                     dgvlist[3, i].Value = string.IsNullOrEmpty(list[i].AddTime.ToString("yyyy-MM-dd hh:mm:ss")) ? "" : list[i].AddTime.ToString("yyyy-MM-dd hh:mm:ss");
                     dgvlist[4, i].Value = diclist.ContainsKey(list[i].GoodsId) ? diclist[list[i].GoodsId].WarnNum.ToString() : "";
                 }

             }
             else
             {
                 dgvlist.Rows.Clear();
             }

         }
        }
        private void FrmWarnGoodsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (list.Count > 0) 
            {
                if (MessageBox.Show("是否全部标记为已读", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //将未读数据标记为已读
                    foreach (var item in list)
                    {
                        item.IsRead = true;
                        WarnLogDAL.edit(item);
                    }

                }
            }
            
        }
    }
}
