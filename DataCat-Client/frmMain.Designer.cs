namespace DataCat_Client
{
    partial class frmMain
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstMenu = new ComponentOwl.BetterListView.BetterListView();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Location = new System.Drawing.Point(-1, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(857, 728);
            this.tcMain.TabIndex = 0;
            this.tcMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcMain_MouseDown_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstMenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstMenu
            // 
            this.lstMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMenu.BackgroundImage = global::DataCat_Client.Resource1.Akasia_Logo;
            this.lstMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lstMenu.BackgroundImageOpacity = ((byte)(80));
            this.lstMenu.Location = new System.Drawing.Point(3, 6);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(840, 693);
            this.lstMenu.TabIndex = 1;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.lstMenu_SelectedIndexChanged_1);
            this.lstMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMenu_MouseClick);
            this.lstMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMenu_MouseDoubleClick);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Location = new System.Drawing.Point(3, 3);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(128, 128);
            this.pbProfilePic.TabIndex = 1;
            this.pbProfilePic.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(863, 147);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pbProfilePic);
            this.panel1.Location = new System.Drawing.Point(866, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 134);
            this.panel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.Text = "DataCat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentOwl.BetterListView.BetterListView lstMenu;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;

    }
}

