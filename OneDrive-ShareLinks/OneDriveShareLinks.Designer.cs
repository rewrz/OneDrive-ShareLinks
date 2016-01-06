namespace OneDrive_ShareLinks
{
    partial class OneDriveShareLinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneDriveShareLinks));
            this.olink = new System.Windows.Forms.TextBox();
            this.olink_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.slink_label = new System.Windows.Forms.Label();
            this.Convert_link = new System.Windows.Forms.Button();
            this.HTTPS = new System.Windows.Forms.TextBox();
            this.copyHttpsTEXT = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.filename_label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Clear1 = new System.Windows.Forms.Button();
            this.Clear3 = new System.Windows.Forms.Button();
            this.Stick2 = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // olink
            // 
            this.olink.Location = new System.Drawing.Point(88, 92);
            this.olink.Name = "olink";
            this.olink.Size = new System.Drawing.Size(429, 20);
            this.olink.TabIndex = 0;
            // 
            // olink_label
            // 
            this.olink_label.AutoSize = true;
            this.olink_label.BackColor = System.Drawing.Color.Transparent;
            this.olink_label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.olink_label.ForeColor = System.Drawing.Color.Blue;
            this.olink_label.Location = new System.Drawing.Point(12, 95);
            this.olink_label.Name = "olink_label";
            this.olink_label.Size = new System.Drawing.Size(70, 12);
            this.olink_label.TabIndex = 3;
            this.olink_label.Text = "公开链接：";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.BackColor = System.Drawing.Color.Transparent;
            this.type_label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type_label.ForeColor = System.Drawing.Color.Blue;
            this.type_label.Location = new System.Drawing.Point(12, 141);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(70, 12);
            this.type_label.TabIndex = 4;
            this.type_label.Text = "后缀格式：";
            // 
            // slink_label
            // 
            this.slink_label.AutoSize = true;
            this.slink_label.BackColor = System.Drawing.Color.Transparent;
            this.slink_label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slink_label.ForeColor = System.Drawing.Color.Black;
            this.slink_label.Location = new System.Drawing.Point(12, 185);
            this.slink_label.Name = "slink_label";
            this.slink_label.Size = new System.Drawing.Size(70, 12);
            this.slink_label.TabIndex = 5;
            this.slink_label.Text = "获得直链：";
            // 
            // Convert_link
            // 
            this.Convert_link.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Convert_link.Location = new System.Drawing.Point(222, 218);
            this.Convert_link.Name = "Convert_link";
            this.Convert_link.Size = new System.Drawing.Size(146, 61);
            this.Convert_link.TabIndex = 6;
            this.Convert_link.Text = "直链转换";
            this.Convert_link.UseVisualStyleBackColor = true;
            this.Convert_link.Click += new System.EventHandler(this.Convert_link_Click);
            // 
            // HTTPS
            // 
            this.HTTPS.Location = new System.Drawing.Point(88, 183);
            this.HTTPS.Name = "HTTPS";
            this.HTTPS.Size = new System.Drawing.Size(429, 20);
            this.HTTPS.TabIndex = 7;
            // 
            // copyHttpsTEXT
            // 
            this.copyHttpsTEXT.Location = new System.Drawing.Point(523, 181);
            this.copyHttpsTEXT.Name = "copyHttpsTEXT";
            this.copyHttpsTEXT.Size = new System.Drawing.Size(45, 23);
            this.copyHttpsTEXT.TabIndex = 9;
            this.copyHttpsTEXT.Text = "复制";
            this.copyHttpsTEXT.UseVisualStyleBackColor = true;
            this.copyHttpsTEXT.Click += new System.EventHandler(this.copyHttpsTEXT_Click);
            // 
            // filename
            // 
            this.filename.BackColor = System.Drawing.SystemColors.Window;
            this.filename.Location = new System.Drawing.Point(88, 44);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(429, 20);
            this.filename.TabIndex = 10;
            this.filename.Text = "Share";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.BackColor = System.Drawing.Color.Transparent;
            this.filename_label.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filename_label.ForeColor = System.Drawing.Color.Black;
            this.filename_label.Location = new System.Drawing.Point(220, 29);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(148, 12);
            this.filename_label.TabIndex = 11;
            this.filename_label.Text = "文件名（非必填项目）：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(508, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By：Chias";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Clear1
            // 
            this.Clear1.BackColor = System.Drawing.Color.Transparent;
            this.Clear1.Location = new System.Drawing.Point(523, 44);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(44, 23);
            this.Clear1.TabIndex = 13;
            this.Clear1.Text = "清空";
            this.Clear1.UseVisualStyleBackColor = false;
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // Clear3
            // 
            this.Clear3.Location = new System.Drawing.Point(523, 136);
            this.Clear3.Name = "Clear3";
            this.Clear3.Size = new System.Drawing.Size(44, 23);
            this.Clear3.TabIndex = 14;
            this.Clear3.Text = "清空";
            this.Clear3.UseVisualStyleBackColor = true;
            this.Clear3.Click += new System.EventHandler(this.Clear3_Click);
            // 
            // Stick2
            // 
            this.Stick2.Location = new System.Drawing.Point(523, 90);
            this.Stick2.Name = "Stick2";
            this.Stick2.Size = new System.Drawing.Size(44, 23);
            this.Stick2.TabIndex = 15;
            this.Stick2.Text = "粘贴";
            this.Stick2.UseVisualStyleBackColor = true;
            this.Stick2.Click += new System.EventHandler(this.Stick2_Click);
            // 
            // type
            // 
            this.type.DisplayMember = "png";
            this.type.FormattingEnabled = true;
            this.type.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.type.Items.AddRange(new object[] {
            "avi",
            "gif",
            "jpg",
            "mp3",
            "mp4",
            "png"});
            this.type.Location = new System.Drawing.Point(88, 136);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(429, 21);
            this.type.TabIndex = 16;
            this.type.Text = "jpg";
            // 
            // OneDriveShareLinks
            // 
            this.AcceptButton = this.Convert_link;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(580, 291);
            this.Controls.Add(this.type);
            this.Controls.Add(this.Stick2);
            this.Controls.Add(this.Clear3);
            this.Controls.Add(this.Clear1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.copyHttpsTEXT);
            this.Controls.Add(this.HTTPS);
            this.Controls.Add(this.Convert_link);
            this.Controls.Add(this.slink_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.olink_label);
            this.Controls.Add(this.olink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OneDriveShareLinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneDrive直链获取";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox olink;
        private System.Windows.Forms.Label olink_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label slink_label;
        private System.Windows.Forms.Button Convert_link;
        private System.Windows.Forms.TextBox HTTPS;
        private System.Windows.Forms.Button copyHttpsTEXT;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Clear1;
        private System.Windows.Forms.Button Clear3;
        private System.Windows.Forms.Button Stick2;
        private System.Windows.Forms.ComboBox type;
    }
}

