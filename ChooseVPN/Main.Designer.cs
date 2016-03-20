namespace ChooseVPN
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessMenustrp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startOpenVpnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateVPNdata = new System.Windows.Forms.Button();
            this.LocalPing = new System.Windows.Forms.Button();
            this.ProxySettingButton = new System.Windows.Forms.Button();
            this.VPNsetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ProcessMenustrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseDown);
            // 
            // ProcessMenustrp
            // 
            this.ProcessMenustrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProcessMenustrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startOpenVpnToolStripMenuItem});
            this.ProcessMenustrp.Name = "ProcessMenustrp";
            this.ProcessMenustrp.Size = new System.Drawing.Size(189, 30);
            this.ProcessMenustrp.Opening += new System.ComponentModel.CancelEventHandler(this.ProcessMenustrp_Opening);
            // 
            // startOpenVpnToolStripMenuItem
            // 
            this.startOpenVpnToolStripMenuItem.Name = "startOpenVpnToolStripMenuItem";
            this.startOpenVpnToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.startOpenVpnToolStripMenuItem.Text = "StartOpenVpn";
            this.startOpenVpnToolStripMenuItem.Click += new System.EventHandler(this.startOpenVpnToolStripMenuItem_Click);
            // 
            // UpdateVPNdata
            // 
            this.UpdateVPNdata.Location = new System.Drawing.Point(12, 12);
            this.UpdateVPNdata.Name = "UpdateVPNdata";
            this.UpdateVPNdata.Size = new System.Drawing.Size(172, 42);
            this.UpdateVPNdata.TabIndex = 1;
            this.UpdateVPNdata.Text = "更新";
            this.UpdateVPNdata.UseVisualStyleBackColor = true;
            this.UpdateVPNdata.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocalPing
            // 
            this.LocalPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalPing.Location = new System.Drawing.Point(792, 12);
            this.LocalPing.Name = "LocalPing";
            this.LocalPing.Size = new System.Drawing.Size(172, 42);
            this.LocalPing.TabIndex = 2;
            this.LocalPing.Text = "LocalPing";
            this.LocalPing.UseVisualStyleBackColor = true;
            this.LocalPing.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProxySettingButton
            // 
            this.ProxySettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProxySettingButton.Location = new System.Drawing.Point(12, 546);
            this.ProxySettingButton.Name = "ProxySettingButton";
            this.ProxySettingButton.Size = new System.Drawing.Size(172, 42);
            this.ProxySettingButton.TabIndex = 3;
            this.ProxySettingButton.Text = "代理设置";
            this.ProxySettingButton.UseVisualStyleBackColor = true;
            this.ProxySettingButton.Click += new System.EventHandler(this.ProxySetting_Click);
            // 
            // VPNsetting
            // 
            this.VPNsetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VPNsetting.Location = new System.Drawing.Point(792, 546);
            this.VPNsetting.Name = "VPNsetting";
            this.VPNsetting.Size = new System.Drawing.Size(172, 42);
            this.VPNsetting.TabIndex = 4;
            this.VPNsetting.Text = "VPN设置";
            this.VPNsetting.UseVisualStyleBackColor = true;
            this.VPNsetting.Click += new System.EventHandler(this.VPNsetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 600);
            this.Controls.Add(this.VPNsetting);
            this.Controls.Add(this.ProxySettingButton);
            this.Controls.Add(this.LocalPing);
            this.Controls.Add(this.UpdateVPNdata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ProcessMenustrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateVPNdata;
        private System.Windows.Forms.Button LocalPing;
        private System.Windows.Forms.Button ProxySettingButton;
        private System.Windows.Forms.ContextMenuStrip ProcessMenustrp;
        private System.Windows.Forms.ToolStripMenuItem startOpenVpnToolStripMenuItem;
        private System.Windows.Forms.Button VPNsetting;
    }
}

