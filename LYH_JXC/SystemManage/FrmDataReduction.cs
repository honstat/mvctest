using LYH_JXC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC.SystemManage
{
    public partial class FrmDataReduction : Form
    {
        public FrmDataReduction()
        {
            InitializeComponent();
        }

        private void bntOpent_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.bak)|*.bak|All files (*.*)|*.* ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPaht.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            if (textPaht.Text != "")
            {
                new MasterDataHelper().huanyuan(textPaht.Text, "LYH_JXC2");
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("为了避免数据丢失，在数据库还原后将关闭整个系统");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("请选择备份文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
