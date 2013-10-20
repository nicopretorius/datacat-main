namespace DPL_0001
{
    partial class UserMaintenance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewUser = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewPic = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpUserSearch = new System.Windows.Forms.GroupBox();
            this.userLookup1 = new DataCat.Controls.UserLookup();
            this.grpNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.grpUserSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewUser
            // 
            this.grpNewUser.Controls.Add(this.btnLoad);
            this.grpNewUser.Controls.Add(this.txtConfirmPassword);
            this.grpNewUser.Controls.Add(this.btnCapture);
            this.grpNewUser.Controls.Add(this.label5);
            this.grpNewUser.Controls.Add(this.btnNewPic);
            this.grpNewUser.Controls.Add(this.txtPassword);
            this.grpNewUser.Controls.Add(this.label4);
            this.grpNewUser.Controls.Add(this.txtUserName);
            this.grpNewUser.Controls.Add(this.label3);
            this.grpNewUser.Controls.Add(this.txtUserID);
            this.grpNewUser.Controls.Add(this.label2);
            this.grpNewUser.Controls.Add(this.imgVideo);
            this.grpNewUser.Location = new System.Drawing.Point(12, 94);
            this.grpNewUser.Name = "grpNewUser";
            this.grpNewUser.Size = new System.Drawing.Size(532, 279);
            this.grpNewUser.TabIndex = 1;
            this.grpNewUser.TabStop = false;
            this.grpNewUser.Text = "User Details";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(415, 243);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(97, 103);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(109, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(344, 243);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(65, 23);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm Password";
            // 
            // btnNewPic
            // 
            this.btnNewPic.Location = new System.Drawing.Point(230, 243);
            this.btnNewPic.Name = "btnNewPic";
            this.btnNewPic.Size = new System.Drawing.Size(108, 23);
            this.btnNewPic.TabIndex = 4;
            this.btnNewPic.Text = "Take New Picture";
            this.btnNewPic.UseVisualStyleBackColor = true;
            this.btnNewPic.Click += new System.EventHandler(this.btnNewPic_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(109, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(109, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(97, 27);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(109, 20);
            this.txtUserID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // imgVideo
            // 
            this.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgVideo.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.imgVideo.Location = new System.Drawing.Point(230, 19);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(296, 218);
            this.imgVideo.TabIndex = 2;
            this.imgVideo.TabStop = false;
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(174, 379);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClose.TabIndex = 4;
            this.btnCancelClose.Text = "&Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 379);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // grpUserSearch
            // 
            this.grpUserSearch.Controls.Add(this.userLookup1);
            this.grpUserSearch.Location = new System.Drawing.Point(12, 4);
            this.grpUserSearch.Name = "grpUserSearch";
            this.grpUserSearch.Size = new System.Drawing.Size(532, 84);
            this.grpUserSearch.TabIndex = 0;
            this.grpUserSearch.TabStop = false;
            this.grpUserSearch.Text = "User Search";
            // 
            // userLookup1
            // 
            this.userLookup1.Location = new System.Drawing.Point(9, 19);
            this.userLookup1.Name = "userLookup1";
            this.userLookup1.Size = new System.Drawing.Size(517, 54);
            this.userLookup1.TabIndex = 0;
            this.userLookup1.UserSelected += new DataCat.Controls.UserSelectedHandler(this.userLookup1_UserSelected);
            // 
            // UserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.grpUserSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpNewUser);
            this.Name = "UserMaintenance";
            this.Size = new System.Drawing.Size(758, 416);
            this.Load += new System.EventHandler(this.UserMaintenance_Load);
            this.grpNewUser.ResumeLayout(false);
            this.grpNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.grpUserSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewPic;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button btnCancelClose;
        private System.Windows.Forms.Button btnNew;
        private DataCat.Controls.UserLookup userLookup1;
        private System.Windows.Forms.GroupBox grpUserSearch;

    }
}
