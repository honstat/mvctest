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

namespace LYH_JXC.GoodsIn
{
    public partial class FrmGoodsQuery : Form
    {
        public FrmGoodsQuery()
        {
            InitializeComponent();
        }
        #region 查询
        public string tb_JhGoodsInfoFind(string strObject, int intFalg)
        {
            string strSecar = null;
            try
            {
                switch (intFalg)
                {
                    case 1://"商品编号":
                        strSecar = @"select s.GoodsId,s.AddTime,e.RealName,w.Name 'WareName',g.GoodsName,Price,Num from a_Stock s
left join a_Emp e on s.EmpId =e.EmpId join a_Ware w on s.WareId = w.WareId join a_Goods g on s.GoodsId =g.GoodsId
where 1=1 and s.GoodsId like '%" + strObject + "%'";
                        break;
                    case 2://商品名称"

                        strSecar = @"select s.GoodsId,s.AddTime,e.RealName,w.Name 'WareName',g.GoodsName,Price,Num from a_Stock s
left join a_Emp e on s.EmpId =e.EmpId join a_Ware w on s.WareId = w.WareId join a_Goods g on s.GoodsId =g.GoodsId
where 1=1 and g.GoodsName like '%" + strObject + "%'";
                        break;
                    case 3://有商品编号和日期
                           string date = "";
                           if (dateTimePickerdate.Text.Trim() != "" && dateTimePickerdateEnd.Text.Trim() != "")
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'and s.AddTime <='" + dateTimePickerdateEnd.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        else
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        strSecar = @"select s.GoodsId,s.AddTime,e.RealName,w.Name 'WareName',g.GoodsName,Price,Num from a_Stock s
left join a_Emp e on s.EmpId =e.EmpId join a_Ware w on s.WareId = w.WareId join a_Goods g on s.GoodsId =g.GoodsId
where 1=1 and s.GoodsId like '%" + strObject + "%'"+date;
                        break;
                    case 4://有商品名称和日期:

                        if (dateTimePickerdate.Text.Trim() != "" && dateTimePickerdateEnd.Text.Trim() != "")
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'and s.AddTime <='" + dateTimePickerdateEnd.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        else
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        strSecar = @"select s.GoodsId,s.AddTime,e.RealName,w.Name 'WareName',g.GoodsName,Price,Num from a_Stock s
left join a_Emp e on s.EmpId =e.EmpId join a_Ware w on s.WareId = w.WareId join a_Goods g on s.GoodsId =g.GoodsId
where 1=1 and g.GoodsName like '%" + strObject + "%'"+date;
                        break;
                    case 5://只有日期:

                        if (dateTimePickerdate.Text.Trim() != "" && dateTimePickerdateEnd.Text.Trim() != "")
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'and s.AddTime <='" + dateTimePickerdateEnd.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        else
                        {
                            date = " and s.AddTime >='" + dateTimePickerdate.Value.ToString("yyyy-MM-dd") + "'";
                        }
                        strSecar = @"select s.GoodsId,s.AddTime,e.RealName,w.Name 'WareName',g.GoodsName,Price,Num from a_Stock s
left join a_Emp e on s.EmpId =e.EmpId join a_Ware w on s.WareId = w.WareId join a_Goods g on s.GoodsId =g.GoodsId
where 1=1 "+date;
                        
     
                        break;
                }
            
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            return strSecar;
        }
        #endregion

        private void BindData() 
        {
            string sqlstr = string.Empty;
            bool ishasdate=false;
            if (string.IsNullOrEmpty(dateTimePickerdate.Text.Trim()))
                {
                ishasdate=false;
                }
                else
                {
                    //日期不为空，查日期
                ishasdate=true;
                }
            if (string.IsNullOrEmpty(cbxQueryType.Text.Trim()))
            {
                //日期不为空，查日期
              sqlstr=  tb_JhGoodsInfoFind(txtKeyWord.Text, 5);
            }
            else
            {
              
                switch (cbxQueryType.Text)
                {
                    case "商品编号":
                        if (ishasdate)
                            sqlstr = tb_JhGoodsInfoFind(txtKeyWord.Text, 3);
                        else
                            sqlstr = tb_JhGoodsInfoFind(txtKeyWord.Text, 1);


                        break;
                    case "商品名称":
                        if (ishasdate)
                            sqlstr = tb_JhGoodsInfoFind(txtKeyWord.Text, 4);
                        else
                            sqlstr = tb_JhGoodsInfoFind(txtKeyWord.Text, 2);

                        break;
                }
            }
            List<Stockty>list= StockDAL.queryForList(sqlstr);
            if (list != null && list.Count > 0)
            {
                dgvlist.RowCount = list.Count;
                for (int i = 0; i < list.Count; i++)
                {

                    dgvlist[0, i].Value = list[i].GoodsId.ToString();
                    dgvlist[1, i].Value = string.IsNullOrEmpty(list[i].GoodsName.ToString()) ? "" : list[i].GoodsName.ToString();
                    dgvlist[2, i].Value = string.IsNullOrEmpty(list[i].WareName.ToString()) ? "" : list[i].WareName.ToString();
                    dgvlist[3, i].Value = string.IsNullOrEmpty(list[i].Num.ToString()) ? "" : list[i].Num.ToString();
                    dgvlist[4, i].Value = string.IsNullOrEmpty(list[i].Price.ToString()) ? "" : list[i].Price.ToString();
                    dgvlist[5, i].Value = string.IsNullOrEmpty(list[i].AddTime.ToString()) ? "" : list[i].AddTime.ToString();
                    dgvlist[6, i].Value = string.IsNullOrEmpty(list[i].RealName.ToString()) ? "" : list[i].RealName.ToString();
                }

            }
            else
            {
                dgvlist.Rows.Clear();
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (dateTimePickerdateEnd.Text.Trim() != "" && dateTimePickerdateEnd.Text.Trim() == "") 
            {
                MessageBox.Show("请选择开始时间");
                return;
            }
            else if (dateTimePickerdateEnd.Text.Trim() != "" && dateTimePickerdateEnd.Text.Trim() != "") 
            {
                if (dateTimePickerdate.Value > dateTimePickerdateEnd.Value) 
                {
                    DateTime temp = dateTimePickerdateEnd.Value;
                   dateTimePickerdateEnd.Value = dateTimePickerdate.Value;
                   dateTimePickerdate.Value = temp;

                }
                else if (dateTimePickerdate.Value == dateTimePickerdateEnd.Value) 
                {
                    dateTimePickerdateEnd.Value = dateTimePickerdateEnd.Value.AddDays(1);
                }
            }
            BindData();
        }

        private void FrmGoodsQuery_Load(object sender, EventArgs e)
        {
            this.dateTimePickerdate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerdateEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerdate.CustomFormat = " ";
            dateTimePickerdateEnd.CustomFormat = " ";
            cbxQueryType.SelectedIndex = 0;
            BindData();
        }

        private void dateTimePickerdate_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerdate.CustomFormat = null;
        }

        private void dateTimePickerdateEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerdateEnd.CustomFormat = null;
        }
    }
}
