using LYH_JXC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYH_JXC.SystemManage
{
    public partial class FrmDataBack : Form
    {
        public FrmDataBack()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text != "" && txtName.Text != "")
                {
                    bool isok = new MasterDataHelper().back(txtPath.Text, txtName.Text, "LYH_JXC2");
                  if (isok)
                    {
                        MessageBox.Show("数据备份成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("数据备份失败！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请填写备份的正确位置及文件名！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
    }
}
