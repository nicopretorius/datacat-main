namespace DPL_0004
{
    partial class ProjectMaintenance
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.projectLookup1 = new DataCat.Controls.ProjectLookup();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.clientLookup1 = new DataCat.Controls.ClientLookup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.grpSearch.SuspendLayout();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.projectLookup1);
            this.grpSearch.Location = new System.Drawing.Point(3, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(715, 62);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Project";
            // 
            // projectLookup1
            // 
            this.projectLookup1.Location = new System.Drawing.Point(6, 18);
            this.projectLookup1.Name = "projectLookup1";
            this.projectLookup1.Size = new System.Drawing.Size(668, 38);
            this.projectLookup1.TabIndex = 0;
            this.projectLookup1.ProjectSelected += new DataCat.Controls.ProjectSelectedHandler(this.projectLookup1_ProjectSelected);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.cmbProject);
            this.grpData.Controls.Add(this.label5);
            this.grpData.Controls.Add(this.dtpDeadLine);
            this.grpData.Controls.Add(this.label4);
            this.grpData.Controls.Add(this.dtpEndDate);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.dtpStartDate);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.clientLookup1);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.txtDescription);
            this.grpData.Location = new System.Drawing.Point(9, 72);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(709, 447);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            this.grpData.Text = "Project Details";
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Location = new System.Drawing.Point(152, 203);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(189, 20);
            this.dtpDeadLine.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deadline";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(152, 177);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(189, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(152, 150);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(189, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // clientLookup1
            // 
            this.clientLookup1.Location = new System.Drawing.Point(17, 13);
            this.clientLookup1.Name = "clientLookup1";
            this.clientLookup1.Size = new System.Drawing.Size(711, 36);
            this.clientLookup1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(152, 49);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(189, 92);
            this.txtDescription.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 525);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 525);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Project Type";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(152, 230);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(189, 21);
            this.cmbProject.TabIndex = 5;
            // 
            // ProjectMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpSearch);
            this.Name = "ProjectMaintenance";
            this.Size = new System.Drawing.Size(722, 565);
            this.grpSearch.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataCat.Controls.ProjectLookup projectLookup1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private DataCat.Controls.ClientLookup clientLookup1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label5;
    }
}
