namespace financial_freedom_c
{
    partial class MainMenu
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picDepartmentLogo = new System.Windows.Forms.PictureBox();
            this.picUniversityLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmentLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUniversityLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(383, 252);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(261, 256);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "USERNAME :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(259, 320);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(383, 316);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(211, 427);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(187, 63);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(438, 427);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picDepartmentLogo
            // 
            this.picDepartmentLogo.Image = global::financial_freedom_c.Properties.Resources.download__6_;
            this.picDepartmentLogo.Location = new System.Drawing.Point(685, 15);
            this.picDepartmentLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picDepartmentLogo.Name = "picDepartmentLogo";
            this.picDepartmentLogo.Size = new System.Drawing.Size(215, 171);
            this.picDepartmentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDepartmentLogo.TabIndex = 8;
            this.picDepartmentLogo.TabStop = false;
            // 
            // picUniversityLogo
            // 
            this.picUniversityLogo.Image = global::financial_freedom_c.Properties.Resources.download__5_;
            this.picUniversityLogo.Location = new System.Drawing.Point(29, 15);
            this.picUniversityLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picUniversityLogo.Name = "picUniversityLogo";
            this.picUniversityLogo.Size = new System.Drawing.Size(289, 160);
            this.picUniversityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUniversityLogo.TabIndex = 7;
            this.picUniversityLogo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 554);
            this.Controls.Add(this.picDepartmentLogo);
            this.Controls.Add(this.picUniversityLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmentLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUniversityLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picUniversityLogo;
        private System.Windows.Forms.PictureBox picDepartmentLogo;
    }
}

