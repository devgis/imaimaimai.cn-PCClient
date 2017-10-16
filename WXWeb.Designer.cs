namespace immmclient
{
    partial class WXWeb
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
            this.pMain = new System.Windows.Forms.PictureBox();
            this.btVisitWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMain.Image = global::immmclient.Properties.Resources.QQ图片20170912154644;
            this.pMain.Location = new System.Drawing.Point(138, 10);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(258, 258);
            this.pMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMain.TabIndex = 3;
            this.pMain.TabStop = false;
            // 
            // btVisitWeb
            // 
            this.btVisitWeb.Location = new System.Drawing.Point(222, 335);
            this.btVisitWeb.Name = "btVisitWeb";
            this.btVisitWeb.Size = new System.Drawing.Size(96, 41);
            this.btVisitWeb.TabIndex = 4;
            this.btVisitWeb.Text = "访问网站";
            this.btVisitWeb.UseVisualStyleBackColor = true;
            this.btVisitWeb.Click += new System.EventHandler(this.btVisitWeb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "爱迈网(www.imaimaimai.cn)专业做好优惠券";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "(微信扫一扫关注公众号直接文字语音搜索优惠券)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "（合作机会加QQ:80163278 QQ群：332309724)";
            // 
            // WXWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVisitWeb);
            this.Controls.Add(this.pMain);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WXWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关注";
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.PictureBox pMain;
        private System.Windows.Forms.Button btVisitWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

