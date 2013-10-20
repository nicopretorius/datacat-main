namespace DataCat.Controls
{
    partial class UserLookup
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
            this.lblLookup = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLookup
            // 
            this.lblLookup.AutoSize = true;
            this.lblLookup.Location = new System.Drawing.Point(2, 8);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(68, 13);
            this.lblLookup.TabIndex = 0;
            this.lblLookup.Text = "User Lookup";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Location = new System.Drawing.Point(376, 9);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedUser.TabIndex = 2;
            // 
            // UserLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectedUser);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblLookup);
            this.Name = "UserLookup";
            this.Size = new System.Drawing.Size(543, 30);
            this.Load += new System.EventHandler(this.UserLookup_Load);
            this.Enter += new System.EventHandler(this.UserLookup_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLookup;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSelectedUser;
    }
}
