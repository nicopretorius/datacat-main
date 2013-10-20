namespace DataCat.Controls
{
    partial class dlgClientLookup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstClients = new ComponentOwl.BetterListView.BetterListView();
            ((System.ComponentModel.ISupportInitialize)(this.lstClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Critera";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(12, 288);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 1;
            this.btnUse.Text = "Select";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 254);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(688, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lstClients
            // 
            this.lstClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstClients.Location = new System.Drawing.Point(0, 0);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(791, 241);
            this.lstClients.TabIndex = 5;
            this.lstClients.DrawItemBackground += new ComponentOwl.BetterListView.BetterListViewDrawItemBackgroundEventHandler(this.lstClients_DrawItemBackground);
            this.lstClients.DoubleClick += new System.EventHandler(this.lstClients_DoubleClick);
            this.lstClients.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstClients_KeyUp);
            // 
            // dlgClientLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstClients);
            this.Name = "dlgClientLookup";
            this.Text = "Client Lookup";
            ((System.ComponentModel.ISupportInitialize)(this.lstClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.TextBox txtSearch;
        private ComponentOwl.BetterListView.BetterListView lstClients;
    }
}