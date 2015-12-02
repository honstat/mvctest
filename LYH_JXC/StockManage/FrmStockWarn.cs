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

namespace LYH_JXC.StockManage
{
    public partial class FrmStockWarn : Form
    {
        public int goodId = 0;
        public FrmStockWarn()
        {
            InitializeComponent();
        }

        private void btnSelectGoods_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGoodsInfo frm = new FrmGoodsInfo();
                frm.Owner = this;
                frm.opertype = 3;//库存预警类别
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStockWarnNum();
        }
        private void SaveStockWarnNum() 
        {
            if(string.IsNullOrEmpty(txtGoodsName.Text.Trim()))
            {
                MessageBox.Show("请选择商品");
            }else
            if (string.IsNullOrEmpty(txtWarnNum.Text.Trim())) 
            {
                MessageBox.Show("请选择预警数量");
            }else
            if (!string.IsNullOrEmpty(txtWarnNum.Text.Trim())&&Convert.ToInt32(txtWarnNum.Text.Trim())<0)
            {
                MessageBox.Show("预警数量必须大于等于0");
            }
            //获取商品
          var model=  GoodsDAL.getEntryById<Goods, int>(goodId);
          if (model == null)
          {
              MessageBox.Show("未找到该商品信息");
          }
          else 
          {
              model.WarnNum = Convert.ToInt32(txtWarnNum.Text.Trim());
              GoodsDAL.edit(model);
              MessageBox.Show("保存成功");
              
          }
        }
    }
}
