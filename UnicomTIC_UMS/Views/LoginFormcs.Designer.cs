namespace UnicomTIC_UMS.Views
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(57, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Userneme";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(57, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(60, 197);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(87, 16);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "\"Select Role\"";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(220, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Student",
            "Lecturer"});
            this.cmbRole.Location = new System.Drawing.Point(220, 188);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 24);
            this.cmbRole.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(609, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(316, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 16);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Unicom Tic Login";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.Text = "unimcom tic login";
            this.Load += new System.EventHandler(this.btnExit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}