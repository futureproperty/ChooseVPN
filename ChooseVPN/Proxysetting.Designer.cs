namespace ChooseVPN
{
    partial class Proxysetting
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
            this.UseSystemProxyFlag = new System.Windows.Forms.CheckBox();
            this.UseProxyFlag = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UseSystemProxyFlag
            // 
            this.UseSystemProxyFlag.AutoSize = true;
            this.UseSystemProxyFlag.Enabled = false;
            this.UseSystemProxyFlag.Location = new System.Drawing.Point(25, 23);
            this.UseSystemProxyFlag.Name = "UseSystemProxyFlag";
            this.UseSystemProxyFlag.Size = new System.Drawing.Size(119, 19);
            this.UseSystemProxyFlag.TabIndex = 0;
            this.UseSystemProxyFlag.Text = "使用系统代理";
            this.UseSystemProxyFlag.UseVisualStyleBackColor = true;
            // 
            // UseProxyFlag
            // 
            this.UseProxyFlag.AutoSize = true;
            this.UseProxyFlag.Location = new System.Drawing.Point(25, 48);
            this.UseProxyFlag.Name = "UseProxyFlag";
            this.UseProxyFlag.Size = new System.Drawing.Size(134, 19);
            this.UseProxyFlag.TabIndex = 1;
            this.UseProxyFlag.Text = "使用自定义代理";
            this.UseProxyFlag.UseVisualStyleBackColor = true;
            this.UseProxyFlag.CheckedChanged += new System.EventHandler(this.UseProxyFlag_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 25);
            this.textBox2.TabIndex = 3;
            // 
            // Proxysetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UseProxyFlag);
            this.Controls.Add(this.UseSystemProxyFlag);
            this.Name = "Proxysetting";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proxysetting_FormClosing);
            this.Load += new System.EventHandler(this.Proxysetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UseSystemProxyFlag;
        private System.Windows.Forms.CheckBox UseProxyFlag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}