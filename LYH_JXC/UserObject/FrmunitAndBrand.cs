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

namespace LYH_JXC.UserObject
{
    public partial class FrmunitAndBrand : Form
    {
        Dictionary<string, Dic> diclist = new Dictionary<string, Dic>();
        Dic currmodel = new Dic();
        List<Dic> brandlist = new List<Dic>();
        List<Dic> unitlist = new List<Dic>();
        List<Dic> goodtypelist = new List<Dic>();
        public FrmunitAndBrand()
        {
            InitializeComponent();
            BinddgvData();
            cbxSearchtype.SelectedIndex = 0;
        }

        public void BinddgvData()
        {
            int N = 0;
            List<Dic> list = DicDAL.Getlist("", 2, out N);
            diclist=list.ToDictionary(x => x.KeyName);

            brandlist = list.Where(x => x.KeyType == "商品品牌").ToList();
            unitlist = list.Where(x => x.KeyType == "商品单位").ToList();
            goodtypelist = list.Where(x => x.KeyType == "商品类别").ToList();
           
            //品牌
            if (brandlist != null && brandlist.Count > 0)
            {
                dgvbrandlist.RowCount = brandlist.Count;
                for (int i = 0; i < brandlist.Count; i++)
                {
                    dgvbrandlist[0, i].Value = brandlist[i].KeyId;
                    dgvbrandlist[1, i].Value = brandlist[i].KeyName;
                    dgvbrandlist[2, i].Value = brandlist[i].SortId;
                  
                }

            }
            else
            {
                dgvtypelist.Rows.Clear();
            }
            //单位
            if (unitlist != null && unitlist.Count > 0)
            {
                dgvunitlist.RowCount = unitlist.Count;
                for (int i = 0; i < unitlist.Count; i++)
                {
                    dgvunitlist[0, i].Value = unitlist[i].KeyId;
                    dgvunitlist[1, i].Value = unitlist[i].KeyName;
                    dgvunitlist[2, i].Value = unitlist[i].SortId;

                }

            }
            else
            {
                dgvtypelist.Rows.Clear();
            }
            //类别
            if (goodtypelist != null && goodtypelist.Count > 0)
            {
                dgvtypelist.RowCount = goodtypelist.Count;
                for (int i = 0; i < goodtypelist.Count; i++)
                {
                    dgvtypelist[0, i].Value = goodtypelist[i].KeyId;
                    dgvtypelist[1, i].Value = goodtypelist[i].KeyName;
                    dgvtypelist[2, i].Value = goodtypelist[i].SortId;

                }

            }
            else
            {
                dgvtypelist.Rows.Clear();
            }
            //清空
            currmodel.KeyId = 0;

        }
        public bool getvalue(string name) 
        {
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名称不能为空");
                return false;
            }
            else if (name.Length > 50) 
            {
                MessageBox.Show("名称不能超过50个字符");
                return false;
            }

            if (diclist.ContainsKey(name) && currmodel.KeyId != diclist[name].KeyId) 
            {
                MessageBox.Show("不能重复插入");
                return false;  
            }
            return true;
        }



        //类型-改
        private void tstypeupdate_Click(object sender, EventArgs e)
        {
            if (dgvtypelist.Rows.Count > 0)
            {
               string key = this.dgvtypelist[1, this.dgvtypelist.CurrentCell.RowIndex].Value.ToString();
               currmodel = diclist[key];
               if (currmodel != null) 
               {
                   txttypename.Text = currmodel.KeyName;
                   updowntype.Value = currmodel.SortId.HasValue?currmodel.SortId.Value :10;
               }
            }
        }
        //类型-删
        private void tstypedelete_Click(object sender, EventArgs e)
        {
            if (dgvtypelist.Rows.Count > 0)
            {
                string key = this.dgvtypelist[1, this.dgvtypelist.CurrentCell.RowIndex].Value.ToString();
                currmodel = diclist[key];
                if (currmodel != null)
                {
                    if (MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DicDAL.DeleteEntry<Dic, long>(currmodel.KeyId);
                        BinddgvData();
                        MessageBox.Show("保存成功");

                    }
                }
            }
        }

        //单位-改
        private void tsunitupdate_Click(object sender, EventArgs e)
        {
            if (dgvunitlist.Rows.Count > 0)
            {
                string key = this.dgvunitlist[1, this.dgvunitlist.CurrentCell.RowIndex].Value.ToString();
                currmodel = diclist[key];
                if (currmodel != null)
                {
                   this.txtnuitname.Text = currmodel.KeyName;
                    updownunit.Value = currmodel.SortId.HasValue ? currmodel.SortId.Value : 10;
                   
                }
            }
        }
        //单位-删
        private void tsunitdelete_Click(object sender, EventArgs e)
        {
            if (dgvunitlist.Rows.Count > 0)
            {
                string key = this.dgvunitlist[1, this.dgvunitlist.CurrentCell.RowIndex].Value.ToString();
                currmodel = diclist[key];
                if (currmodel != null)
                {
                    if (MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DicDAL.DeleteEntry<Dic, long>(currmodel.KeyId);
                        BinddgvData();
                        MessageBox.Show("保存成功");

                    }
                }
            }
        }

        //品牌-改
        private void tsbrandupdate_Click(object sender, EventArgs e)
        {
            if (dgvbrandlist.Rows.Count > 0)
            {
                string key = this.dgvbrandlist[1, this.dgvbrandlist.CurrentCell.RowIndex].Value.ToString();
                currmodel = diclist[key];
                if (currmodel != null)
                {
                    txttypename.Text = currmodel.KeyName;
                    updownbrand.Value = currmodel.SortId.HasValue ? currmodel.SortId.Value : 10;
                }
            }
        }
        //品牌-删
        private void tsbranddelete_Click(object sender, EventArgs e)
        {
            if (dgvbrandlist.Rows.Count > 0)
            {
                string key = this.dgvbrandlist[1, this.dgvbrandlist.CurrentCell.RowIndex].Value.ToString();
                currmodel = diclist[key];
                if (currmodel != null)
                {
                    if (MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DicDAL.DeleteEntry<Dic, long>(currmodel.KeyId);
                        BinddgvData();
                        MessageBox.Show("保存成功");
                       
                    }
                
                }
            }
        }
        //类别-保存
        private void btntypesave_Click(object sender, EventArgs e)
        {
            if (getvalue(txttypename.Text.Trim())) 
            {
                currmodel.KeyName = txttypename.Text.Trim();
                currmodel.SortId =Convert.ToInt32(updowntype.Value);
                currmodel.KeyType = "商品类别";
                if (currmodel.KeyId == 0)
                    DicDAL.add(currmodel);
                else
                DicDAL.edit(currmodel);
                BinddgvData();
                MessageBox.Show("保存成功");
            }
        }
        //单位-保存
        private void btnunitsave_Click(object sender, EventArgs e)
        {
            if (getvalue(txtnuitname.Text.Trim()))
            {
                currmodel.KeyName = txtnuitname.Text.Trim();
                currmodel.SortId = Convert.ToInt32(updownunit.Value);
                currmodel.KeyType = "商品单位";
                if (currmodel.KeyId == 0)
                    DicDAL.add(currmodel);
                else
                DicDAL.edit(currmodel);
                BinddgvData();
                MessageBox.Show("保存成功");
            }
        }
        //品牌-保存
        private void btnbrandsave_Click(object sender, EventArgs e)
        {
            if (getvalue(txtbrandname.Text.Trim()))
            {
                currmodel.KeyName = txtbrandname.Text.Trim();
                currmodel.SortId = Convert.ToInt32(updownbrand.Value);
                currmodel.KeyType = "商品品牌";
                if (currmodel.KeyId == 0)
                    DicDAL.add(currmodel);
                else
                DicDAL.edit(currmodel);
                BinddgvData();
                MessageBox.Show("保存成功");
            }
        }
        //搜索
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string type = cbxSearchtype.Text.Trim();
            
            if (type == "类别")
            {
              var query = goodtypelist.Where(l => l.KeyName.Contains(txtname.Text.Trim())).ToList();

              //品牌
              if (query != null && query.Count > 0)
              {
                  dgvtypelist.RowCount = query.Count;
                  for (int i = 0; i < query.Count; i++)
                  {
                      dgvtypelist[0, i].Value = query[i].KeyId;
                      dgvtypelist[1, i].Value = query[i].KeyName;
                      dgvtypelist[2, i].Value = query[i].SortId;

                  }

              }
              else
              {
                  dgvtypelist.Rows.Clear();
              }
            }
            else if(type == "品牌")
            {
                var query = brandlist.Where(l => l.KeyName.Contains(txtname.Text.Trim())).ToList();
                //品牌
                if (query != null && query.Count > 0)
                {
                    dgvunitlist.RowCount = query.Count;
                    for (int i = 0; i < query.Count; i++)
                    {
                        dgvbrandlist[0, i].Value = query[i].KeyId;
                        dgvbrandlist[1, i].Value = query[i].KeyName;
                        dgvbrandlist[2, i].Value = query[i].SortId;

                    }

                }
                else
                {
                    dgvunitlist.Rows.Clear();
                }
            }
            else if (type == "单位") 
            {
                var query = brandlist.Where(l => l.KeyName.Contains(txtname.Text.Trim())).ToList();
                //品牌
                if (query != null && query.Count > 0)
                {
                    dgvbrandlist.RowCount = query.Count;
                    for (int i = 0; i < query.Count; i++)
                    {
                        dgvbrandlist[0, i].Value = query[i].KeyId;
                        dgvbrandlist[1, i].Value = query[i].KeyName;
                        dgvbrandlist[2, i].Value = query[i].SortId;

                    }

                }
                else
                {
                    dgvbrandlist.Rows.Clear();
                }
            }

        }
    }
}
