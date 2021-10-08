
namespace PRG282_Project
{
    partial class Login
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.cbxNUser = new System.Windows.Forms.CheckBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblConPass = new System.Windows.Forms.Label();
            this.tbxConPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gbxLogin.Controls.Add(this.cbxNUser);
            this.gbxLogin.Controls.Add(this.lblOutput);
            this.gbxLogin.Controls.Add(this.lblConPass);
            this.gbxLogin.Controls.Add(this.tbxConPassword);
            this.gbxLogin.Controls.Add(this.btnLogIn);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.label2);
            this.gbxLogin.Controls.Add(this.label1);
            this.gbxLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(269, 284);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Log In To The Program";
            // 
            // cbxNUser
            // 
            this.cbxNUser.AutoSize = true;
            this.cbxNUser.Location = new System.Drawing.Point(183, 19);
            this.cbxNUser.Name = "cbxNUser";
            this.cbxNUser.Size = new System.Drawing.Size(73, 17);
            this.cbxNUser.TabIndex = 11;
            this.cbxNUser.Text = "New User";
            this.cbxNUser.UseVisualStyleBackColor = true;
            this.cbxNUser.CheckedChanged += new System.EventHandler(this.cbxNUser_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(147, 56);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 10;
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Location = new System.Drawing.Point(6, 139);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(94, 13);
            this.lblConPass.TabIndex = 7;
            this.lblConPass.Text = "Confirm Password:";
            this.lblConPass.Visible = false;
            // 
            // tbxConPassword
            // 
            this.tbxConPassword.BackColor = System.Drawing.Color.Gray;
            this.tbxConPassword.Enabled = false;
            this.tbxConPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxConPassword.Location = new System.Drawing.Point(6, 155);
            this.tbxConPassword.Name = "tbxConPassword";
            this.tbxConPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxConPassword.TabIndex = 6;
            this.tbxConPassword.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(9, 196);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(247, 72);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.Gray;
            this.tbxUsername.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxUsername.Location = new System.Drawing.Point(6, 49);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Gray;
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxPassword.Location = new System.Drawing.Point(6, 104);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.gbxLogin);
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.CheckBox cbxNUser;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.TextBox tbxConPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

