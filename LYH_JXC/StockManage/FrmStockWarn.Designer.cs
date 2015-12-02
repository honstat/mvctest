namespace LYH_JXC.StockManage
{
    partial class FrmStockWarn
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
            this.groupBoxinfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectGoods = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarnNum = new System.Windows.Forms.TextBox();
            this.groupBoxinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.btnSave);
            this.groupBoxinfo.Controls.Add(this.txtGoodsName);
            this.groupBoxinfo.Controls.Add(this.label2);
            this.groupBoxinfo.Controls.Add(this.btnSelectGoods);
            this.groupBoxinfo.Controls.Add(this.label5);
            this.groupBoxinfo.Controls.Add(this.txtWarnNum);
            this.groupBoxinfo.Location = new System.Drawing.Point(12, 27);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(375, 148);
            this.groupBoxinfo.TabIndex = 113;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "库存预警设定";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Enabled = false;
            this.txtGoodsName.Location = new System.Drawing.Point(83, 30);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(117, 21);
            this.txtGoodsName.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 93;
            this.label2.Text = "商品名称：";
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.Location = new System.Drawing.Point(206, 30);
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.Size = new System.Drawing.Size(32, 23);
            this.btnSelectGoods.TabIndex = 110;
            this.btnSelectGoods.Text = "..";
            this.btnSelectGoods.UseVisualStyleBackColor = true;
            this.btnSelectGoods.Click += new System.EventHandler(this.btnSelectGoods_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 96;
            this.label5.Text = "预警数量：";
            // 
            // txtWarnNum
            // 
            this.txtWarnNum.Location = new System.Drawing.Point(83, 69);
            this.txtWarnNum.Name = "txtWarnNum";
            this.txtWarnNum.Size = new System.Drawing.Size(120, 21);
            this.txtWarnNum.TabIndex = 108;
            // 
            // FrmStockWarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 187);
            this.Controls.Add(this.groupBoxinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStockWarn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存预警管理";
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxinfo;
        public System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectGoods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtWarnNum;
    }
}