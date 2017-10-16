namespace immmclient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btWebImaimai = new System.Windows.Forms.Button();
            this.btWeb = new System.Windows.Forms.Button();
            this.tbWords = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.PictureBox();
            this.btGetCoupon = new System.Windows.Forms.Button();
            this.btShowInfo = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couponurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colbuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btWebImaimai);
            this.panel1.Controls.Add(this.btWeb);
            this.panel1.Controls.Add(this.tbWords);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 50);
            this.panel1.TabIndex = 0;
            // 
            // btWebImaimai
            // 
            this.btWebImaimai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btWebImaimai.Location = new System.Drawing.Point(610, 5);
            this.btWebImaimai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btWebImaimai.Name = "btWebImaimai";
            this.btWebImaimai.Size = new System.Drawing.Size(100, 38);
            this.btWebImaimai.TabIndex = 3;
            this.btWebImaimai.Text = "访问网站";
            this.btWebImaimai.UseVisualStyleBackColor = true;
            this.btWebImaimai.Click += new System.EventHandler(this.btWebImaimai_Click);
            // 
            // btWeb
            // 
            this.btWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btWeb.Location = new System.Drawing.Point(504, 5);
            this.btWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btWeb.Name = "btWeb";
            this.btWeb.Size = new System.Drawing.Size(100, 38);
            this.btWeb.TabIndex = 2;
            this.btWeb.Text = "关注";
            this.btWeb.UseVisualStyleBackColor = true;
            this.btWeb.Click += new System.EventHandler(this.btWeb_Click);
            // 
            // tbWords
            // 
            this.tbWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWords.Location = new System.Drawing.Point(7, 11);
            this.tbWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(386, 26);
            this.tbWords.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(400, 5);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(100, 38);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "查找";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbDesc);
            this.panel2.Controls.Add(this.pMain);
            this.panel2.Controls.Add(this.btGetCoupon);
            this.panel2.Controls.Add(this.btShowInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(720, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(296, 491);
            this.panel2.TabIndex = 1;
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesc.Location = new System.Drawing.Point(19, 286);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(258, 144);
            this.tbDesc.TabIndex = 3;
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMain.Location = new System.Drawing.Point(19, 17);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(258, 258);
            this.pMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMain.TabIndex = 2;
            this.pMain.TabStop = false;
            // 
            // btGetCoupon
            // 
            this.btGetCoupon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btGetCoupon.Location = new System.Drawing.Point(150, 453);
            this.btGetCoupon.Name = "btGetCoupon";
            this.btGetCoupon.Size = new System.Drawing.Size(75, 31);
            this.btGetCoupon.TabIndex = 1;
            this.btGetCoupon.Text = "领券";
            this.btGetCoupon.UseVisualStyleBackColor = true;
            this.btGetCoupon.Click += new System.EventHandler(this.btGetCoupon_Click);
            // 
            // btShowInfo
            // 
            this.btShowInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btShowInfo.Location = new System.Drawing.Point(69, 453);
            this.btShowInfo.Name = "btShowInfo";
            this.btShowInfo.Size = new System.Drawing.Size(75, 31);
            this.btShowInfo.TabIndex = 0;
            this.btShowInfo.Text = "详情";
            this.btShowInfo.UseVisualStyleBackColor = true;
            this.btShowInfo.Click += new System.EventHandler(this.btShowInfo_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemid,
            this.citemurl,
            this.couponurl,
            this.cName,
            this.ShopName,
            this.Coupon,
            this.cInfo,
            this.colbuy});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(4, 55);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(708, 441);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvList_Scroll);
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // citemurl
            // 
            this.citemurl.HeaderText = "citemurl";
            this.citemurl.Name = "citemurl";
            this.citemurl.ReadOnly = true;
            this.citemurl.Visible = false;
            // 
            // couponurl
            // 
            this.couponurl.HeaderText = "couponurl";
            this.couponurl.Name = "couponurl";
            this.couponurl.ReadOnly = true;
            this.couponurl.Visible = false;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.HeaderText = " 名称";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // ShopName
            // 
            this.ShopName.HeaderText = "店铺名称";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            // 
            // Coupon
            // 
            this.Coupon.HeaderText = "优惠券";
            this.Coupon.Name = "Coupon";
            this.Coupon.ReadOnly = true;
            // 
            // cInfo
            // 
            this.cInfo.HeaderText = "";
            this.cInfo.Name = "cInfo";
            this.cInfo.ReadOnly = true;
            // 
            // colbuy
            // 
            this.colbuy.HeaderText = "";
            this.colbuy.Name = "colbuy";
            this.colbuy.ReadOnly = true;
            this.colbuy.Text = "领券购买";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "爱迈网优惠券助手";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbWords;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btWebImaimai;
        private System.Windows.Forms.Button btWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.Button btGetCoupon;
        private System.Windows.Forms.Button btShowInfo;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.PictureBox pMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemurl;
        private System.Windows.Forms.DataGridViewTextBoxColumn couponurl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coupon;
        private System.Windows.Forms.DataGridViewButtonColumn cInfo;
        private System.Windows.Forms.DataGridViewButtonColumn colbuy;
    }
}

