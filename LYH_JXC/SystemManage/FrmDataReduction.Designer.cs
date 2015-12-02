namespace LYH_JXC.SystemManage
{
    partial class FrmDataReduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntOk = new System.Windows.Forms.Button();
            this.textPaht = new System.Windows.Forms.TextBox();
            this.bntOpent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(12, 67);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(120, 23);
            this.bntOk.TabIndex = 11;
            this.bntOk.Text = "确定(&D)";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // textPaht
            // 
            this.textPaht.Enabled = false;
            this.textPaht.Location = new System.Drawing.Point(154, 15);
            this.textPaht.Multiline = true;
            this.textPaht.Name = "textPaht";
            this.textPaht.Size = new System.Drawing.Size(266, 77);
            this.textPaht.TabIndex = 10;
            // 
            // bntOpent
            // 
            this.bntOpent.Location = new System.Drawing.Point(12, 38);
            this.bntOpent.Name = "bntOpent";
            this.bntOpent.Size = new System.Drawing.Size(120, 23);
            this.bntOpent.TabIndex = 9;
            this.bntOpent.Text = "打开(&O)";
            this.bntOpent.UseVisualStyleBackColor = true;
            this.bntOpent.Click += new System.EventHandler(this.bntOpent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "数据备份后的文件路径：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmDataReduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 104);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.textPaht);
            this.Controls.Add(this.bntOpent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDataReduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库还原";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.TextBox textPaht;
        private System.Windows.Forms.Button bntOpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}