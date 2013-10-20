namespace DataCat.Controls
{
    partial class ProjectLookup
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
            this.lblSelectedProject = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblLookup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectedProject
            // 
            this.lblSelectedProject.AutoSize = true;
            this.lblSelectedProject.Location = new System.Drawing.Point(451, 13);
            this.lblSelectedProject.Name = "lblSelectedProject";
            this.lblSelectedProject.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedProject.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(149, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp_1);
            // 
            // lblLookup
            // 
            this.lblLookup.AutoSize = true;
            this.lblLookup.Location = new System.Drawing.Point(3, 12);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(79, 13);
            this.lblLookup.TabIndex = 3;
            this.lblLookup.Text = "Project Lookup";
            // 
            // ProjectLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectedProject);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblLookup);
            this.Name = "ProjectLookup";
            this.Size = new System.Drawing.Size(668, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedProject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLookup;
    }
}
