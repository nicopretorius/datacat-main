namespace DataCat_Client
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(85, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "nico";
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "nicolaas";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(184, 112);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.btnQuit);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtHost);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Location = new System.Drawing.Point(126, 93);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(280, 148);
            this.gbLogin.TabIndex = 6;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "DataCat Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(85, 86);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(174, 20);
            this.txtHost.TabIndex = 6;
            this.txtHost.Text = "headoffice.marconi.co.za";
            this.txtHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHost_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DataCat_Client.Properties.Resources.LoginBackdrop1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(551, 325);
            this.Controls.Add(this.gbLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataCat Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
    }
}