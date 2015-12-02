namespace LYH_JXC.GoodsIn
{
    partial class FrmGoodsInManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodsInManage));
            this.groupboxinfo = new System.Windows.Forms.GroupBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.btnGoodSelect = new System.Windows.Forms.Button();
            this.cbxemployee = new System.Windows.Forms.ComboBox();
            this.cmbDepotName = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdate = new System.Windows.Forms.DateTimePicker();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsJhPrice = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.tollDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.groupboxinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxinfo
            // 
            this.groupboxinfo.Controls.Add(this.lblUnitName);
            this.groupboxinfo.Controls.Add(this.btnGoodSelect);
            this.groupboxinfo.Controls.Add(this.cbxemployee);
            this.groupboxinfo.Controls.Add(this.cmbDepotName);
            this.groupboxinfo.Controls.Add(this.dateTimePickerdate);
            this.groupboxinfo.Controls.Add(this.txtGoodsNum);
            this.groupboxinfo.Controls.Add(this.txtGoodsName);
            this.groupboxinfo.Controls.Add(this.txtGoodsJhPrice);
            this.groupboxinfo.Controls.Add(this.label23);
            this.groupboxinfo.Controls.Add(this.label24);
            this.groupboxinfo.Controls.Add(this.label20);
            this.groupboxinfo.Controls.Add(this.label19);
            this.groupboxinfo.Controls.Add(this.label17);
            this.groupboxinfo.Controls.Add(this.label16);
            this.groupboxinfo.Location = new System.Drawing.Point(13, 37);
            this.groupboxinfo.Name = "groupboxinfo";
            this.groupboxinfo.Size = new System.Drawing.Size(593, 150);
            this.groupboxinfo.TabIndex = 54;
            this.groupboxinfo.TabStop = false;
            this.groupboxinfo.Text = "进货信息";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(474, 59);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(0, 12);
            this.lblUnitName.TabIndex = 107;
            // 
            // btnGoodSelect
            // 
            this.btnGoodSelect.Location = new System.Drawing.Point(230, 18);
            this.btnGoodSelect.Name = "btnGoodSelect";
            this.btnGoodSelect.Size = new System.Drawing.Size(44, 23);
            this.btnGoodSelect.TabIndex = 106;
            this.btnGoodSelect.Text = "...";
            this.btnGoodSelect.UseVisualStyleBackColor = true;
            this.btnGoodSelect.Click += new System.EventHandler(this.btnGoodSelect_Click);
            // 
            // cbxemployee
            // 
            this.cbxemployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxemployee.FormattingEnabled = true;
            this.cbxemployee.Location = new System.Drawing.Point(373, 21);
            this.cbxemployee.Name = "cbxemployee";
            this.cbxemployee.Size = new System.Drawing.Size(153, 20);
            this.cbxemployee.TabIndex = 104;
            // 
            // cmbDepotName
            // 
            this.cmbDepotName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepotName.FormattingEnabled = true;
            this.cmbDepotName.Items.AddRange(new object[] {
            "A仓库",
            "烟酒",
            "电器",
            "床上",
            "食品",
            "电动"});
            this.cmbDepotName.Location = new System.Drawing.Point(373, 88);
            this.cmbDepotName.Name = "cmbDepotName";
            this.cmbDepotName.Size = new System.Drawing.Size(153, 20);
            this.cmbDepotName.TabIndex = 103;
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(83, 86);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(190, 21);
            this.dateTimePickerdate.TabIndex = 98;
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(373, 54);
            this.txtGoodsNum.MaxLength = 10;
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(82, 21);
            this.txtGoodsNum.TabIndex = 94;
            this.txtGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNum_KeyPress);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(83, 22);
            this.txtGoodsName.MaxLength = 20;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(136, 21);
            this.txtGoodsName.TabIndex = 93;
            // 
            // txtGoodsJhPrice
            // 
            this.txtGoodsJhPrice.Location = new System.Drawing.Point(83, 53);
            this.txtGoodsJhPrice.MaxLength = 10;
            this.txtGoodsJhPrice.Name = "txtGoodsJhPrice";
            this.txtGoodsJhPrice.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsJhPrice.TabIndex = 92;
            this.txtGoodsJhPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsJhPrice_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(302, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 86;
            this.label23.Text = "进货数量：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(288, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 85;
            this.label24.Text = "所属仓库：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(301, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 83;
            this.label20.Text = "进货员工：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 82;
            this.label19.Text = "商品名称：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 81;
            this.label17.Text = "进货日期：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 80;
            this.label16.Text = "进货单价：";
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgvlist.Location = new System.Drawing.Point(0, 205);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowHeadersVisible = false;
            this.dgvlist.RowTemplate.Height = 23;
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlist.Size = new System.Drawing.Size(608, 232);
            this.dgvlist.TabIndex = 53;
            this.dgvlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "仓库名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "数量";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "进货单价";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "进货日期";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.tollDelete,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(52, 22);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(52, 22);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // tollDelete
            // 
            this.tollDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollDelete.Name = "tollDelete";
            this.tollDelete.Size = new System.Drawing.Size(36, 22);
            this.tollDelete.Text = "删除";
            this.tollDelete.Click += new System.EventHandler(this.tollDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // FrmGoodsInManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 435);
            this.Controls.Add(this.groupboxinfo);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGoodsInManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货信息";
            this.groupboxinfo.ResumeLayout(false);
            this.groupboxinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton tollDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.GroupBox groupboxinfo;
        private System.Windows.Forms.ComboBox cbxemployee;
        private System.Windows.Forms.ComboBox cmbDepotName;
        private System.Windows.Forms.DateTimePicker dateTimePickerdate;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsJhPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGoodSelect;
        public System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Label lblUnitName;
    }
}