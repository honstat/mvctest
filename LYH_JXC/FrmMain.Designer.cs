namespace LYH_JXC
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.DeepCyan = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblReadName = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsObjectInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGoodsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGoodsQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGoodsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalesManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGoodsSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGoodsReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStockManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStockWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStockQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWarnGoodslist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDataBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDataReduction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPublic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsModifySkin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsfun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAboutOur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDicMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerNow
            // 
            this.timerNow.Interval = 3600;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // DeepCyan
            // 
            this.DeepCyan.SkinPassword = null;
            this.DeepCyan.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("DeepCyan.SkinSteam")));
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(725, 653);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 14);
            this.lbltime.TabIndex = 3;
            // 
            // lblReadName
            // 
            this.lblReadName.AutoSize = true;
            this.lblReadName.BackColor = System.Drawing.Color.Transparent;
            this.lblReadName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReadName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReadName.Location = new System.Drawing.Point(370, 653);
            this.lblReadName.Name = "lblReadName";
            this.lblReadName.Size = new System.Drawing.Size(49, 14);
            this.lblReadName.TabIndex = 2;
            this.lblReadName.Text = "欢迎你";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsObjectInfo,
            this.tsPurchase,
            this.tsSalesManager,
            this.tsStockManager,
            this.tsSystem,
            this.tsPublic,
            this.tsAboutMenu});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(879, 25);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsObjectInfo
            // 
            this.tsObjectInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsSupplier,
            this.tsDicMenu});
            this.tsObjectInfo.Name = "tsObjectInfo";
            this.tsObjectInfo.Size = new System.Drawing.Size(68, 21);
            this.tsObjectInfo.Text = "基本档案";
            // 
            // tsEmployee
            // 
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(172, 22);
            this.tsEmployee.Text = "员工信息";
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsSupplier
            // 
            this.tsSupplier.Name = "tsSupplier";
            this.tsSupplier.Size = new System.Drawing.Size(172, 22);
            this.tsSupplier.Text = "供应商信息";
            this.tsSupplier.Click += new System.EventHandler(this.tsSupplier_Click);
            // 
            // tsPurchase
            // 
            this.tsPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGoodsAdd,
            this.tsGoodsQuery,
            this.tsGoodsInfo});
            this.tsPurchase.Name = "tsPurchase";
            this.tsPurchase.Size = new System.Drawing.Size(68, 21);
            this.tsPurchase.Text = "进货管理";
            // 
            // tsGoodsAdd
            // 
            this.tsGoodsAdd.Name = "tsGoodsAdd";
            this.tsGoodsAdd.Size = new System.Drawing.Size(172, 22);
            this.tsGoodsAdd.Text = "进货";
            this.tsGoodsAdd.Click += new System.EventHandler(this.tsGoodsAdd_Click);
            // 
            // tsGoodsQuery
            // 
            this.tsGoodsQuery.Name = "tsGoodsQuery";
            this.tsGoodsQuery.Size = new System.Drawing.Size(172, 22);
            this.tsGoodsQuery.Text = "进货查询";
            this.tsGoodsQuery.Click += new System.EventHandler(this.tsGoodsQuery_Click);
            // 
            // tsGoodsInfo
            // 
            this.tsGoodsInfo.Name = "tsGoodsInfo";
            this.tsGoodsInfo.Size = new System.Drawing.Size(172, 22);
            this.tsGoodsInfo.Text = "商品基本信息维护";
            this.tsGoodsInfo.Click += new System.EventHandler(this.tsGoodsInfo_Click);
            // 
            // tsSalesManager
            // 
            this.tsSalesManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGoodsSales,
            this.tsGoodsReturn});
            this.tsSalesManager.Name = "tsSalesManager";
            this.tsSalesManager.Size = new System.Drawing.Size(68, 21);
            this.tsSalesManager.Text = "销售管理";
            // 
            // tsGoodsSales
            // 
            this.tsGoodsSales.Name = "tsGoodsSales";
            this.tsGoodsSales.Size = new System.Drawing.Size(124, 22);
            this.tsGoodsSales.Text = "商品销售";
            this.tsGoodsSales.Click += new System.EventHandler(this.tsGoodsSales_Click);
            // 
            // tsGoodsReturn
            // 
            this.tsGoodsReturn.Name = "tsGoodsReturn";
            this.tsGoodsReturn.Size = new System.Drawing.Size(124, 22);
            this.tsGoodsReturn.Text = "商品退货";
            this.tsGoodsReturn.Click += new System.EventHandler(this.tsGoodsReturn_Click);
            // 
            // tsStockManager
            // 
            this.tsStockManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStockWarning,
            this.tsStockQuery,
            this.tsWarnGoodslist});
            this.tsStockManager.Name = "tsStockManager";
            this.tsStockManager.Size = new System.Drawing.Size(68, 21);
            this.tsStockManager.Text = "库存管理";
            // 
            // tsStockWarning
            // 
            this.tsStockWarning.Name = "tsStockWarning";
            this.tsStockWarning.Size = new System.Drawing.Size(148, 22);
            this.tsStockWarning.Text = "库存警报设置";
            this.tsStockWarning.Click += new System.EventHandler(this.tsStockWarning_Click);
            // 
            // tsStockQuery
            // 
            this.tsStockQuery.Name = "tsStockQuery";
            this.tsStockQuery.Size = new System.Drawing.Size(148, 22);
            this.tsStockQuery.Text = "库存查询";
            this.tsStockQuery.Click += new System.EventHandler(this.tsStockQuery_Click);
            // 
            // tsWarnGoodslist
            // 
            this.tsWarnGoodslist.Name = "tsWarnGoodslist";
            this.tsWarnGoodslist.Size = new System.Drawing.Size(148, 22);
            this.tsWarnGoodslist.Text = "库存报警商品";
            this.tsWarnGoodslist.Click += new System.EventHandler(this.tsWarnGoodslist_Click);
            // 
            // tsSystem
            // 
            this.tsSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDataBackUp,
            this.tsDataReduction});
            this.tsSystem.Name = "tsSystem";
            this.tsSystem.Size = new System.Drawing.Size(68, 21);
            this.tsSystem.Text = "系统维护";
            // 
            // tsDataBackUp
            // 
            this.tsDataBackUp.Name = "tsDataBackUp";
            this.tsDataBackUp.Size = new System.Drawing.Size(124, 22);
            this.tsDataBackUp.Text = "数据备份";
            this.tsDataBackUp.Click += new System.EventHandler(this.tsDataBackUp_Click);
            // 
            // tsDataReduction
            // 
            this.tsDataReduction.Name = "tsDataReduction";
            this.tsDataReduction.Size = new System.Drawing.Size(124, 22);
            this.tsDataReduction.Text = "数据还原";
            this.tsDataReduction.Click += new System.EventHandler(this.tsDataReduction_Click);
            // 
            // tsPublic
            // 
            this.tsPublic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsModifyPwd,
            this.tsModifySkin,
            this.tsExit});
            this.tsPublic.Name = "tsPublic";
            this.tsPublic.Size = new System.Drawing.Size(68, 21);
            this.tsPublic.Text = "用户菜单";
            // 
            // tsModifyPwd
            // 
            this.tsModifyPwd.Name = "tsModifyPwd";
            this.tsModifyPwd.Size = new System.Drawing.Size(124, 22);
            this.tsModifyPwd.Text = "修改密码";
            this.tsModifyPwd.Click += new System.EventHandler(this.tsModifyPwd_Click);
            // 
            // tsModifySkin
            // 
            this.tsModifySkin.Name = "tsModifySkin";
            this.tsModifySkin.Size = new System.Drawing.Size(124, 22);
            this.tsModifySkin.Text = "切换皮肤";
            this.tsModifySkin.Click += new System.EventHandler(this.tsModifySkin_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(124, 22);
            this.tsExit.Text = "注销系统";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsAboutMenu
            // 
            this.tsAboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsfun,
            this.tsAboutOur});
            this.tsAboutMenu.Name = "tsAboutMenu";
            this.tsAboutMenu.Size = new System.Drawing.Size(44, 21);
            this.tsAboutMenu.Text = "关于";
            // 
            // tsfun
            // 
            this.tsfun.Name = "tsfun";
            this.tsfun.Size = new System.Drawing.Size(124, 22);
            this.tsfun.Text = "关于功能";
            this.tsfun.Click += new System.EventHandler(this.tsfun_Click);
            // 
            // tsAboutOur
            // 
            this.tsAboutOur.Name = "tsAboutOur";
            this.tsAboutOur.Size = new System.Drawing.Size(124, 22);
            this.tsAboutOur.Text = "关于我们";
            this.tsAboutOur.Click += new System.EventHandler(this.tsAboutOur_Click);
            // 
            // tsDicMenu
            // 
            this.tsDicMenu.Name = "tsDicMenu";
            this.tsDicMenu.Size = new System.Drawing.Size(172, 22);
            this.tsDicMenu.Text = "类别品牌信息维护";
            this.tsDicMenu.Click += new System.EventHandler(this.tsDicMenu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 677);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblReadName);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进销存管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsObjectInfo;
        private System.Windows.Forms.ToolStripMenuItem tsEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsSupplier;
        private System.Windows.Forms.ToolStripMenuItem tsPurchase;
        private System.Windows.Forms.ToolStripMenuItem tsGoodsAdd;
        private System.Windows.Forms.ToolStripMenuItem tsGoodsQuery;
        private System.Windows.Forms.ToolStripMenuItem tsSalesManager;
        private System.Windows.Forms.ToolStripMenuItem tsGoodsSales;
        private System.Windows.Forms.ToolStripMenuItem tsGoodsReturn;
        private System.Windows.Forms.ToolStripMenuItem tsStockManager;
        private System.Windows.Forms.ToolStripMenuItem tsStockWarning;
        private System.Windows.Forms.ToolStripMenuItem tsStockQuery;
        private System.Windows.Forms.ToolStripMenuItem tsSystem;
        private System.Windows.Forms.ToolStripMenuItem tsDataBackUp;
        private System.Windows.Forms.ToolStripMenuItem tsDataReduction;
        private System.Windows.Forms.ToolStripMenuItem tsAboutMenu;
        private System.Windows.Forms.ToolStripMenuItem tsfun;
        private System.Windows.Forms.ToolStripMenuItem tsAboutOur;
        private System.Windows.Forms.ToolStripMenuItem tsGoodsInfo;
        private System.Windows.Forms.ToolStripMenuItem tsPublic;
        private System.Windows.Forms.Label lblReadName;
        private System.Windows.Forms.ToolStripMenuItem tsModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.ToolStripMenuItem tsModifySkin;
        private Sunisoft.IrisSkin.SkinCollectionItem DeepCyan;
        private System.Windows.Forms.ToolStripMenuItem tsWarnGoodslist;
        private System.Windows.Forms.ToolStripMenuItem tsDicMenu;
    }
}