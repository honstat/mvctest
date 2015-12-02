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
namespace LYH_JXC
{
    public partial class FrmSkinLook : Form
    {
        Sunisoft.IrisSkin.SkinEngine se = null;
        string currskin = "";
        public FrmSkinLook()
        {
            
            InitializeComponent();
            base.ResumeLayout(false);
	         base.PerformLayout();
             getskin("");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currskin))
            {
                MessageBox.Show("请选择皮肤");
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["SkinName"].Value = currskin;
                config.Save();
                if (MessageBox.Show("重新启动程序以应用新配置", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Application.Restart();
            }
        }

        private void getskin(string skinname)
        {
            InitializeComponent();



            if (se == null)
            {
                se = new Sunisoft.IrisSkin.SkinEngine(this);
               skinname= ConfigurationManager.AppSettings["SkinName"].ToString();
            }
           
            if (string.IsNullOrEmpty(skinname))
            {
                se.SkinFile = Application.StartupPath + "\\skin/DeepCyan.ssk";
            }
            else
            {
                se.SkinFile = Application.StartupPath + "\\skin/" + skinname + ".ssk";
                currskin = skinname;
            }
            se.Active = true;
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

        }



    

        private void buttonskin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            getskin(btn.Text.Trim());

        }

        private void FrmSkinLook_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
        }
    }
}
