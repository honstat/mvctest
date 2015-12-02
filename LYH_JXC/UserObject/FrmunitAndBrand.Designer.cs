namespace LYH_JXC.UserObject
{
    partial class FrmunitAndBrand
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtypelist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstypeupdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tstypedelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvunitlist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmunit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsunitupdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsunitdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvbrandlist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbrand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbrandupdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbranddelete = new System.Windows.Forms.ToolStripMenuItem();
            this.updowntype = new System.Windows.Forms.NumericUpDown();
            this.txttypename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntypesave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnunitsave = new System.Windows.Forms.Button();
            this.updownunit = new System.Windows.Forms.NumericUpDown();
            this.txtnuitname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnbrandsave = new System.Windows.Forms.Button();
            this.updownbrand = new System.Windows.Forms.NumericUpDown();
            this.txtbrandname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSearchtype = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtypelist)).BeginInit();
            this.cmType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunitlist)).BeginInit();
            this.cmunit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbrandlist)).BeginInit();
            this.cmbrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updowntype)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownunit)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvtypelist);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品类别";
            // 
            // dgvtypelist
            // 
            this.dgvtypelist.AllowUserToAddRows = false;
            this.dgvtypelist.AllowUserToDeleteRows = false;
            this.dgvtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtypelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvtypelist.ContextMenuStrip = this.cmType;
            this.dgvtypelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtypelist.Location = new System.Drawing.Point(3, 17);
            this.dgvtypelist.Name = "dgvtypelist";
            this.dgvtypelist.ReadOnly = true;
            this.dgvtypelist.RowHeadersVisible = false;
            this.dgvtypelist.RowTemplate.Height = 23;
            this.dgvtypelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtypelist.Size = new System.Drawing.Size(406, 159);
            this.dgvtypelist.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "排序";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cmType
            // 
            this.cmType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstypeupdate,
            this.tstypedelete});
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(101, 48);
            // 
            // tstypeupdate
            // 
            this.tstypeupdate.Name = "tstypeupdate";
            this.tstypeupdate.Size = new System.Drawing.Size(100, 22);
            this.tstypeupdate.Text = "修改";
            this.tstypeupdate.Click += new System.EventHandler(this.tstypeupdate_Click);
            // 
            // tstypedelete
            // 
            this.tstypedelete.Name = "tstypedelete";
            this.tstypedelete.Size = new System.Drawing.Size(100, 22);
            this.tstypedelete.Text = "删除";
            this.tstypedelete.Click += new System.EventHandler(this.tstypedelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvunitlist);
            this.groupBox2.Location = new System.Drawing.Point(13, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品单位";
            // 
            // dgvunitlist
            // 
            this.dgvunitlist.AllowUserToAddRows = false;
            this.dgvunitlist.AllowUserToDeleteRows = false;
            this.dgvunitlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunitlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvunitlist.ContextMenuStrip = this.cmunit;
            this.dgvunitlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvunitlist.Location = new System.Drawing.Point(3, 17);
            this.dgvunitlist.Name = "dgvunitlist";
            this.dgvunitlist.ReadOnly = true;
            this.dgvunitlist.RowHeadersVisible = false;
            this.dgvunitlist.RowTemplate.Height = 23;
            this.dgvunitlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvunitlist.Size = new System.Drawing.Size(406, 159);
            this.dgvunitlist.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "编号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "排序";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cmunit
            // 
            this.cmunit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsunitupdate,
            this.tsunitdelete});
            this.cmunit.Name = "cmunit";
            this.cmunit.Size = new System.Drawing.Size(101, 48);
            // 
            // tsunitupdate
            // 
            this.tsunitupdate.Name = "tsunitupdate";
            this.tsunitupdate.Size = new System.Drawing.Size(100, 22);
            this.tsunitupdate.Text = "修改";
            this.tsunitupdate.Click += new System.EventHandler(this.tsunitupdate_Click);
            // 
            // tsunitdelete
            // 
            this.tsunitdelete.Name = "tsunitdelete";
            this.tsunitdelete.Size = new System.Drawing.Size(100, 22);
            this.tsunitdelete.Text = "删除";
            this.tsunitdelete.Click += new System.EventHandler(this.tsunitdelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvbrandlist);
            this.groupBox3.Location = new System.Drawing.Point(12, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "商品品牌";
            // 
            // dgvbrandlist
            // 
            this.dgvbrandlist.AllowUserToAddRows = false;
            this.dgvbrandlist.AllowUserToDeleteRows = false;
            this.dgvbrandlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbrandlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvbrandlist.ContextMenuStrip = this.cmbrand;
            this.dgvbrandlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbrandlist.Location = new System.Drawing.Point(3, 17);
            this.dgvbrandlist.Name = "dgvbrandlist";
            this.dgvbrandlist.ReadOnly = true;
            this.dgvbrandlist.RowHeadersVisible = false;
            this.dgvbrandlist.RowTemplate.Height = 23;
            this.dgvbrandlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbrandlist.Size = new System.Drawing.Size(404, 159);
            this.dgvbrandlist.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "编号";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "排序";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // cmbrand
            // 
            this.cmbrand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbrandupdate,
            this.tsbranddelete});
            this.cmbrand.Name = "cmbrand";
            this.cmbrand.Size = new System.Drawing.Size(101, 48);
            // 
            // tsbrandupdate
            // 
            this.tsbrandupdate.Name = "tsbrandupdate";
            this.tsbrandupdate.Size = new System.Drawing.Size(100, 22);
            this.tsbrandupdate.Text = "修改";
            this.tsbrandupdate.Click += new System.EventHandler(this.tsbrandupdate_Click);
            // 
            // tsbranddelete
            // 
            this.tsbranddelete.Name = "tsbranddelete";
            this.tsbranddelete.Size = new System.Drawing.Size(100, 22);
            this.tsbranddelete.Text = "删除";
            this.tsbranddelete.Click += new System.EventHandler(this.tsbranddelete_Click);
            // 
            // updowntype
            // 
            this.updowntype.Location = new System.Drawing.Point(96, 70);
            this.updowntype.Name = "updowntype";
            this.updowntype.Size = new System.Drawing.Size(120, 21);
            this.updowntype.TabIndex = 12;
            this.updowntype.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txttypename
            // 
            this.txttypename.Location = new System.Drawing.Point(96, 24);
            this.txttypename.Name = "txttypename";
            this.txttypename.Size = new System.Drawing.Size(120, 21);
            this.txttypename.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "排序：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "名称：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btntypesave);
            this.groupBox4.Controls.Add(this.updowntype);
            this.groupBox4.Controls.Add(this.txttypename);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(483, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 111);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "类别编辑";
            // 
            // btntypesave
            // 
            this.btntypesave.Location = new System.Drawing.Point(269, 24);
            this.btntypesave.Name = "btntypesave";
            this.btntypesave.Size = new System.Drawing.Size(75, 23);
            this.btntypesave.TabIndex = 13;
            this.btntypesave.Text = "保存";
            this.btntypesave.UseVisualStyleBackColor = true;
            this.btntypesave.Click += new System.EventHandler(this.btntypesave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(752, 17);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.Text = "搜索";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(655, 17);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(91, 21);
            this.txtname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "名称：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnunitsave);
            this.groupBox5.Controls.Add(this.updownunit);
            this.groupBox5.Controls.Add(this.txtnuitname);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(483, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 111);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "单位编辑";
            // 
            // btnunitsave
            // 
            this.btnunitsave.Location = new System.Drawing.Point(269, 24);
            this.btnunitsave.Name = "btnunitsave";
            this.btnunitsave.Size = new System.Drawing.Size(75, 23);
            this.btnunitsave.TabIndex = 13;
            this.btnunitsave.Text = "保存";
            this.btnunitsave.UseVisualStyleBackColor = true;
            this.btnunitsave.Click += new System.EventHandler(this.btnunitsave_Click);
            // 
            // updownunit
            // 
            this.updownunit.Location = new System.Drawing.Point(96, 70);
            this.updownunit.Name = "updownunit";
            this.updownunit.Size = new System.Drawing.Size(120, 21);
            this.updownunit.TabIndex = 12;
            this.updownunit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtnuitname
            // 
            this.txtnuitname.Location = new System.Drawing.Point(96, 24);
            this.txtnuitname.Name = "txtnuitname";
            this.txtnuitname.Size = new System.Drawing.Size(120, 21);
            this.txtnuitname.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "排序：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "名称：";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnbrandsave);
            this.groupBox6.Controls.Add(this.updownbrand);
            this.groupBox6.Controls.Add(this.txtbrandname);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(483, 421);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 111);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "品牌编辑";
            // 
            // btnbrandsave
            // 
            this.btnbrandsave.Location = new System.Drawing.Point(269, 24);
            this.btnbrandsave.Name = "btnbrandsave";
            this.btnbrandsave.Size = new System.Drawing.Size(75, 23);
            this.btnbrandsave.TabIndex = 13;
            this.btnbrandsave.Text = "保存";
            this.btnbrandsave.UseVisualStyleBackColor = true;
            this.btnbrandsave.Click += new System.EventHandler(this.btnbrandsave_Click);
            // 
            // updownbrand
            // 
            this.updownbrand.Location = new System.Drawing.Point(96, 70);
            this.updownbrand.Name = "updownbrand";
            this.updownbrand.Size = new System.Drawing.Size(120, 21);
            this.updownbrand.TabIndex = 12;
            this.updownbrand.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtbrandname
            // 
            this.txtbrandname.Location = new System.Drawing.Point(96, 24);
            this.txtbrandname.Name = "txtbrandname";
            this.txtbrandname.Size = new System.Drawing.Size(120, 21);
            this.txtbrandname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "排序：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "名称：";
            // 
            // cbxSearchtype
            // 
            this.cbxSearchtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchtype.FormattingEnabled = true;
            this.cbxSearchtype.Items.AddRange(new object[] {
            "类别",
            "单位",
            "品牌"});
            this.cbxSearchtype.Location = new System.Drawing.Point(556, 17);
            this.cbxSearchtype.Name = "cbxSearchtype";
            this.cbxSearchtype.Size = new System.Drawing.Size(93, 20);
            this.cbxSearchtype.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(17, 567);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 12);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "小提示：在视图中单机右键可以显示快捷菜单";
            // 
            // FrmunitAndBrand
            // 
            this.AcceptButton = this.btnsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 587);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbxSearchtype);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmunitAndBrand";
            this.Text = "类别品牌单位维护";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtypelist)).EndInit();
            this.cmType.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunitlist)).EndInit();
            this.cmunit.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbrandlist)).EndInit();
            this.cmbrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updowntype)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownunit)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvtypelist;
        private System.Windows.Forms.ContextMenuStrip cmType;
        private System.Windows.Forms.ToolStripMenuItem tstypeupdate;
        private System.Windows.Forms.ToolStripMenuItem tstypedelete;
        private System.Windows.Forms.DataGridView dgvunitlist;
        private System.Windows.Forms.ContextMenuStrip cmunit;
        private System.Windows.Forms.DataGridView dgvbrandlist;
        private System.Windows.Forms.ContextMenuStrip cmbrand;
        private System.Windows.Forms.ToolStripMenuItem tsunitupdate;
        private System.Windows.Forms.ToolStripMenuItem tsunitdelete;
        private System.Windows.Forms.ToolStripMenuItem tsbrandupdate;
        private System.Windows.Forms.ToolStripMenuItem tsbranddelete;
        private System.Windows.Forms.NumericUpDown updowntype;
        private System.Windows.Forms.TextBox txttypename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btntypesave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnunitsave;
        private System.Windows.Forms.NumericUpDown updownunit;
        private System.Windows.Forms.TextBox txtnuitname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnbrandsave;
        private System.Windows.Forms.NumericUpDown updownbrand;
        private System.Windows.Forms.TextBox txtbrandname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSearchtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label lblTitle;
    }
}