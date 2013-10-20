namespace DataCat.Controls
{
    partial class dlgPersonLookup
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
            this.lsData = new ComponentOwl.BetterListView.BetterListView();
            ((System.ComponentModel.ISupportInitialize)(this.lsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Critera";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(11, 336);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 15;
            this.btnUse.Text = "Select";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(94, 302);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(688, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lsData
            // 
            this.lsData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsData.Location = new System.Drawing.Point(0, 0);
            this.lsData.Name = "lsData";
            this.lsData.Size = new System.Drawing.Size(795, 241);
            this.lsData.TabIndex = 17;
            this.lsData.DrawItemBackground += new ComponentOwl.BetterListView.BetterListViewDrawItemBackgroundEventHandler(this.lsData_DrawItemBackground);
            this.lsData.DoubleClick += new System.EventHandler(this.lsData_DoubleClick);
            this.lsData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsData_KeyUp);
            // 
            // dlgPersonLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsData);
            this.Name = "dlgPersonLookup";
            this.Text = "Person Lookup";
            ((System.ComponentModel.ISupportInitialize)(this.lsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.TextBox txtSearch;
        private ComponentOwl.BetterListView.BetterListView lsData;
    }
}