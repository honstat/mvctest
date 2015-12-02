using LYH_JXC.DAL;
using LYH_JXC.Entity;
using LYH_JXC.UserObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC.GoodsIn
{
    public partial class FrmGoodsInsert : Form
    {
        public int GoodsId = 0;
        public FrmGoodsInsert()
        {
            InitializeComponent();

            binddrop();
        }
        public FrmGoodsInsert(int goodsid)
        {
            InitializeComponent();

            binddrop();
            GoodsId = goodsid;
        }
        List<Dic> brandlist=new List<Dic>();
        List<Dic> unitlist = new List<Dic>();
        List<Dic> goodtypelist = new List<Dic>();
        Goods model = new Goods();
        List<Supplier> suplist = new List<Supplier>();
        private void binddrop()
        {
            int N = 0;
            List<Dic> list = DicDAL.Getlist("", 2, out N);
             brandlist = list.Where(x => x.KeyType == "商品品牌").ToList();
             unitlist = list.Where(x => x.KeyType == "商品单位").ToList();
             goodtypelist = list.Where(x => x.KeyType == "商品类别").ToList();
            //品牌
            cbxbrand.DataSource = brandlist;
            cbxbrand.DisplayMember = "KeyName";
            cbxbrand.ValueMember = "KeyId";
            cbxbrand.SelectedIndex = 0;
            //单位
            cbxunit.DataSource = unitlist;
            cbxunit.DisplayMember = "KeyName";
            cbxunit.ValueMember = "KeyId";
            cbxunit.SelectedIndex = 0;
            //类别
            cbxtype.DataSource = goodtypelist;
            cbxtype.DisplayMember = "KeyName";
            cbxtype.ValueMember = "KeyId";
            cbxtype.SelectedIndex = 0;
            suplist = SupplierDAL.Getlist("", 30, out N);
            if (suplist != null && suplist.Count > 0) 
            {
                cbxsuplier.DataSource = suplist;
                cbxsuplier.DisplayMember = "Name";
                cbxsuplier.ValueMember = "SupplierId";
                cbxsuplier.SelectedIndex = 0;
            }
        }
        private void save() 
        {
            if (txtGoodsName.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品名称");
                return;
            }
            int warnnum=Convert.ToInt32(numericUpDownnum.Value);
            if(warnnum < 0)
            {
            MessageBox.Show("请输入正确的预警数量");
                return;
            }
            model.GoodsName = txtGoodsName.Text.Trim();
            model.KeyBrandId =Convert.ToInt32(cbxbrand.SelectedValue);
            model.KeyTypeId = Convert.ToInt32(cbxtype.SelectedValue);
            model.KeyUnitId = Convert.ToInt32(cbxunit.SelectedValue);
            model.Remark = txtremark.Text.Trim() == "" ? "" : txtremark.Text.Trim().Length > 150 ? txtremark.Text.Trim().Substring(0, 150).ToString() : txtremark.Text.Trim();
            model.SupplierId = Convert.ToInt32(cbxsuplier.SelectedValue);
            model.WarnNum = warnnum;
            //进行重复名监测
            if (GoodsDAL.checkloginName(model.GoodsName,GoodsId)) 
            {
                MessageBox.Show("商品名称已存在");
                return;
            }

            try
            {
                if (GoodsId > 0)
                {
                    GoodsDAL.edit(model);
                }
                else 
                {
                    GoodsDAL.add(model);
                }
              
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存失败，"+ex.Message);
            }
            FrmAllGoods frm = (FrmAllGoods)this.Owner;
            frm.BinddgvData();//刷新
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
                save();
            

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGoodsInsert_Load(object sender, EventArgs e)
        {
            if (GoodsId > 0) 
            {
                //类别为修改，绑定数据
             Goods model=  GoodsDAL.getEntryById<Goods, long>(GoodsId);
             if (model != null) 
             {
                 txtGoodsName.Text = model.GoodsName;
                 txtremark.Text = model.Remark;
                 cbxbrand.Text = brandlist[model.KeyBrandId].KeyName;
                 cbxunit.Text = unitlist[model.KeyUnitId].KeyName;
                 cbxtype.Text = goodtypelist[model.KeyTypeId].KeyName;
             }
            }
        }
    }
}
