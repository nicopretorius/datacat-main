namespace DataCat.Controls
{
    partial class dlgUserLookup
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
            this.lstUsers = new ComponentOwl.BetterListView.BetterListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstUsers.Location = new System.Drawing.Point(0, 0);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(844, 241);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.DrawItemBackground += new ComponentOwl.BetterListView.BetterListViewDrawItemBackgroundEventHandler(this.lstUsers_DrawItemBackground);
            this.lstUsers.DoubleClick += new System.EventHandler(this.lstUsers_DoubleClick);
            this.lstUsers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstUsers_KeyUp);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 247);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(688, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(12, 281);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 1;
            this.btnUse.Text = "Select";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Critera";
            // 
            // dlgUserLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstUsers);
            this.Name = "dlgUserLookup";
            this.Text = "User Lookup";
            this.Load += new System.EventHandler(this.dlgUserLookup_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dlgUserLookup_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentOwl.BetterListView.BetterListView lstUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}