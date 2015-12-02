namespace LYH_JXC.GoodsIn
{
    partial class FrmGoodsInsert
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbxsuplier = new System.Windows.Forms.ComboBox();
            this.numericUpDownnum = new System.Windows.Forms.NumericUpDown();
            this.btncancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxbrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxunit = new System.Windows.Forms.ComboBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBoxinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.label7);
            this.groupBoxinfo.Controls.Add(this.cbxsuplier);
            this.groupBoxinfo.Controls.Add(this.numericUpDownnum);
            this.groupBoxinfo.Controls.Add(this.btncancel);
            this.groupBoxinfo.Controls.Add(this.label6);
            this.groupBoxinfo.Controls.Add(this.cbxtype);
            this.groupBoxinfo.Controls.Add(this.txtremark);
            this.groupBoxinfo.Controls.Add(this.label5);
            this.groupBoxinfo.Controls.Add(this.label4);
            this.groupBoxinfo.Controls.Add(this.label3);
            this.groupBoxinfo.Controls.Add(this.cbxbrand);
            this.groupBoxinfo.Controls.Add(this.label2);
            this.groupBoxinfo.Controls.Add(this.cbxunit);
            this.groupBoxinfo.Controls.Add(this.txtGoodsName);
            this.groupBoxinfo.Controls.Add(this.label1);
            this.groupBoxinfo.Controls.Add(this.btnsave);
            this.groupBoxinfo.Location = new System.Drawing.Point(13, 13);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(450, 329);
            this.groupBoxinfo.TabIndex = 0;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "商品信息";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "供应商：";
            // 
            // cbxsuplier
            // 
            this.cbxsuplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsuplier.FormattingEnabled = true;
            this.cbxsuplier.Location = new System.Drawing.Point(304, 119);
            this.cbxsuplier.Name = "cbxsuplier";
            this.cbxsuplier.Size = new System.Drawing.Size(131, 20);
            this.cbxsuplier.TabIndex = 15;
            // 
            // numericUpDownnum
            // 
            this.numericUpDownnum.Location = new System.Drawing.Point(101, 78);
            this.numericUpDownnum.Name = "numericUpDownnum";
            this.numericUpDownnum.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownnum.TabIndex = 14;
            this.numericUpDownnum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(290, 287);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "商品类别：";
            // 
            // cbxtype
            // 
            this.cbxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.Location = new System.Drawing.Point(89, 119);
            this.cbxtype.Name = "cbxtype";
            this.cbxtype.Size = new System.Drawing.Size(131, 20);
            this.cbxtype.TabIndex = 11;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(89, 164);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(298, 99);
            this.txtremark.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "预警数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "品牌：";
            // 
            // cbxbrand
            // 
            this.cbxbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbrand.FormattingEnabled = true;
            this.cbxbrand.Location = new System.Drawing.Point(304, 78);
            this.cbxbrand.Name = "cbxbrand";
            this.cbxbrand.Size = new System.Drawing.Size(131, 20);
            this.cbxbrand.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "计量单位：";
            // 
            // cbxunit
            // 
            this.cbxunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxunit.FormattingEnabled = true;
            this.cbxunit.Location = new System.Drawing.Point(304, 33);
            this.cbxunit.Name = "cbxunit";
            this.cbxunit.Size = new System.Drawing.Size(131, 20);
            this.cbxunit.TabIndex = 3;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(89, 33);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(131, 21);
            this.txtGoodsName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品名称：";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(188, 287);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FrmGoodsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 354);
            this.Controls.Add(this.groupBoxinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGoodsInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑商品信息";
            this.Load += new System.EventHandler(this.FrmGoodsInsert_Load);
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxinfo;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxbrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxunit;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.NumericUpDown numericUpDownnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxsuplier;
    }
}