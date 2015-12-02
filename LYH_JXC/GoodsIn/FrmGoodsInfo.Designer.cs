namespace LYH_JXC.GoodsIn
{
    partial class FrmGoodsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodsInfo));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.TreeView();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(136, 266);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(45, 23);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(74, 266);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(44, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "确定";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(12, 2);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(183, 258);
            this.tv.TabIndex = 8;
            this.tv.DoubleClick += new System.EventHandler(this.tv_DoubleClick);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "修改.ico");
            this.imglist.Images.SetKeyName(1, "添加.ico");
            // 
            // FrmGoodsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 294);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tv);
            this.Name = "FrmGoodsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品信息表";
            this.Load += new System.EventHandler(this.FrmGoodsInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList imglist;
    }
}