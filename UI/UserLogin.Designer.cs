namespace UI
{
    partial class FormLogin
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
            this.Ulog = new System.Windows.Forms.Label();
            this.UPWD = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtUPWD = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ulog
            // 
            this.Ulog.AutoSize = true;
            this.Ulog.Location = new System.Drawing.Point(70, 44);
            this.Ulog.Name = "Ulog";
            this.Ulog.Size = new System.Drawing.Size(29, 12);
            this.Ulog.TabIndex = 0;
            this.Ulog.Text = "Ulog";
            // 
            // UPWD
            // 
            this.UPWD.AutoSize = true;
            this.UPWD.Location = new System.Drawing.Point(70, 71);
            this.UPWD.Name = "UPWD";
            this.UPWD.Size = new System.Drawing.Size(29, 12);
            this.UPWD.TabIndex = 1;
            this.UPWD.Text = "UPWD";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(117, 41);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(100, 21);
            this.txtUID.TabIndex = 2;
            // 
            // txtUPWD
            // 
            this.txtUPWD.Location = new System.Drawing.Point(117, 68);
            this.txtUPWD.Name = "txtUPWD";
            this.txtUPWD.Size = new System.Drawing.Size(100, 21);
            this.txtUPWD.TabIndex = 3;
            this.txtUPWD.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(56, 108);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(158, 108);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(80, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtUPWD);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.UPWD);
            this.Controls.Add(this.Ulog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ulog;
        private System.Windows.Forms.Label UPWD;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtUPWD;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Quit;
    }
}

