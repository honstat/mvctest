using LYH_JXC.GoodsIn;
using LYH_JXC.GoodsOut;
using LYH_JXC.StockManage;
using LYH_JXC.SystemManage;
using LYH_JXC.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LYH_JXC.UserObject;
namespace LYH_JXC
{
    public partial class FrmMain : BaseForm
    {
        
        public FrmMain()
        {
     
            InitializeComponent();
 
           
            tsObjectInfo.Visible = false;
            tsPurchase.Visible = false;
            tsSalesManager.Visible = false;
            tsStockManager.Visible = false;
            tsSystem.Visible = false;
            showMenu();
            lblReadName.Text = string.IsNullOrEmpty(currentUser.RealName)?"": "欢迎你，"+ currentUser.RealName;
            lbltime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            timerNow.Enabled = true;
        }

        private void showMenu()
        {
            if (myPermissionList.Count > 0)
            {
                switch (currentUser.Role)
                {
                    case 1:
                        //管理员权限
                        tsObjectInfo.Visible = true;
                        tsPurchase.Visible = true;
                        tsSalesManager.Visible = true;
                        tsStockManager.Visible = true;
                        tsSystem.Visible = true;
                        break;

                    case 2:
                        //采购
                        tsPurchase.Visible = true;
                        tsStockManager.Visible = true;
                        break;
                        
                    case 3:
                        //销售员
                        tsSalesManager.Visible = true;
                        break;
                    case 4:
                        //仓库管理员
                        tsStockManager.Visible = true;
                        break;


                }

            }
            else
            {
                //没有任何权限
                MessageBox.Show("请联系管理员加权限");
                //回到登录窗口
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            FrmUserInfo frmuser = new FrmUserInfo();
            frmuser.Owner = this;
            frmuser.ShowDialog();

        }

        private void tsSupplier_Click(object sender, EventArgs e)
        {
            new FrmCompanyInfo().Show();
        }

        private void tsGoodsAdd_Click(object sender, EventArgs e)
        {
            FrmGoodsInManage frm = new FrmGoodsInManage();
            frm.Show();
        }

        private void tsGoodsQuery_Click(object sender, EventArgs e)
        {
            new FrmGoodsQuery().Show();
        }

        private void tsGoodsSales_Click(object sender, EventArgs e)
        {
            new FrmGoodsSales().Show();
        }

        private void tsGoodsReturn_Click(object sender, EventArgs e)
        {
            new FrmReturngoods().Show(); 
        }

        private void tsStockWarning_Click(object sender, EventArgs e)
        {
            new FrmStockWarn().Show(); 
        }

        private void tsStockQuery_Click(object sender, EventArgs e)
        {
            new FrmStockQuery().Show(); 
        }

        private void tsDataBackUp_Click(object sender, EventArgs e)
        {
            new FrmDataBack().ShowDialog(); 
        }

        private void tsDataReduction_Click(object sender, EventArgs e)
        {
            new FrmDataReduction().ShowDialog(); 
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();//注销
            }
        }

        private void tsAboutOur_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void tsfun_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void tsGoodsInfo_Click(object sender, EventArgs e)
        {
            new FrmAllGoods().ShowDialog();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认注销吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();//注销
            }
           
        }

        private void tsModifyPwd_Click(object sender, EventArgs e)
        {
            new FrmModifyPwd().ShowDialog();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }

        private void tsModifySkin_Click(object sender, EventArgs e)
        {
            new FrmSkinLook().ShowDialog();
        }
        //库存已报警商品
        private void tsWarnGoodslist_Click(object sender, EventArgs e)
        {
            new FrmWarnGoodsList().ShowDialog();
        }

        private void tsDicMenu_Click(object sender, EventArgs e)
        {
            new FrmunitAndBrand().ShowDialog();
        }

    

        

       
    }
}
