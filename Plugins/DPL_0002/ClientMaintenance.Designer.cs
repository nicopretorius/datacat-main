namespace DPL_0002
{
    partial class ClientMaintenance
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
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.grpClientSearch = new System.Windows.Forms.GroupBox();
            this.clientLookup1 = new DataCat.Controls.ClientLookup();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpNewClient = new System.Windows.Forms.GroupBox();
            this.btnDeleteLogo = new System.Windows.Forms.Button();
            this.btnLoadLogo = new System.Windows.Forms.Button();
            this.pboxEmail = new System.Windows.Forms.PictureBox();
            this.pboxFacebook = new System.Windows.Forms.PictureBox();
            this.pboxTwitter = new System.Windows.Forms.PictureBox();
            this.pboxSkype = new System.Windows.Forms.PictureBox();
            this.pboxTel = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContactPersonSurname = new System.Windows.Forms.TextBox();
            this.txtContactPersonTel = new System.Windows.Forms.TextBox();
            this.txtContactPersonName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompanyTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSuburb = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddressLine3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.grpClientSearch.SuspendLayout();
            this.grpNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSkype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(168, 572);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClose.TabIndex = 9;
            this.btnCancelClose.Text = "&Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // grpClientSearch
            // 
            this.grpClientSearch.Controls.Add(this.clientLookup1);
            this.grpClientSearch.Location = new System.Drawing.Point(3, 12);
            this.grpClientSearch.Name = "grpClientSearch";
            this.grpClientSearch.Size = new System.Drawing.Size(610, 61);
            this.grpClientSearch.TabIndex = 5;
            this.grpClientSearch.TabStop = false;
            this.grpClientSearch.Text = "Client Search";
            // 
            // clientLookup1
            // 
            this.clientLookup1.Location = new System.Drawing.Point(7, 20);
            this.clientLookup1.Name = "clientLookup1";
            this.clientLookup1.Size = new System.Drawing.Size(519, 36);
            this.clientLookup1.TabIndex = 0;
            this.clientLookup1.ClientSelected += new DataCat.Controls.ClientSelectedHandler(this.clientLookup1_ClientSelected);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 572);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpNewClient
            // 
            this.grpNewClient.Controls.Add(this.btnDeleteLogo);
            this.grpNewClient.Controls.Add(this.btnLoadLogo);
            this.grpNewClient.Controls.Add(this.pboxEmail);
            this.grpNewClient.Controls.Add(this.pboxFacebook);
            this.grpNewClient.Controls.Add(this.pboxTwitter);
            this.grpNewClient.Controls.Add(this.pboxSkype);
            this.grpNewClient.Controls.Add(this.pboxTel);
            this.grpNewClient.Controls.Add(this.label17);
            this.grpNewClient.Controls.Add(this.txtSkype);
            this.grpNewClient.Controls.Add(this.label14);
            this.grpNewClient.Controls.Add(this.label15);
            this.grpNewClient.Controls.Add(this.txtFacebook);
            this.grpNewClient.Controls.Add(this.txtTwitter);
            this.grpNewClient.Controls.Add(this.txtEmail);
            this.grpNewClient.Controls.Add(this.label16);
            this.grpNewClient.Controls.Add(this.txtPostalCode);
            this.grpNewClient.Controls.Add(this.label13);
            this.grpNewClient.Controls.Add(this.label12);
            this.grpNewClient.Controls.Add(this.label11);
            this.grpNewClient.Controls.Add(this.txtContactPersonSurname);
            this.grpNewClient.Controls.Add(this.txtContactPersonTel);
            this.grpNewClient.Controls.Add(this.txtContactPersonName);
            this.grpNewClient.Controls.Add(this.label10);
            this.grpNewClient.Controls.Add(this.txtCompanyTel);
            this.grpNewClient.Controls.Add(this.label9);
            this.grpNewClient.Controls.Add(this.cmbSuburb);
            this.grpNewClient.Controls.Add(this.cmbCity);
            this.grpNewClient.Controls.Add(this.cmbProvince);
            this.grpNewClient.Controls.Add(this.label8);
            this.grpNewClient.Controls.Add(this.label7);
            this.grpNewClient.Controls.Add(this.label6);
            this.grpNewClient.Controls.Add(this.cmbCountry);
            this.grpNewClient.Controls.Add(this.label1);
            this.grpNewClient.Controls.Add(this.txtAddressLine3);
            this.grpNewClient.Controls.Add(this.label5);
            this.grpNewClient.Controls.Add(this.txtAddressLine2);
            this.grpNewClient.Controls.Add(this.label4);
            this.grpNewClient.Controls.Add(this.txtAddressLine1);
            this.grpNewClient.Controls.Add(this.label3);
            this.grpNewClient.Controls.Add(this.txtCompanyName);
            this.grpNewClient.Controls.Add(this.label2);
            this.grpNewClient.Controls.Add(this.imgLogo);
            this.grpNewClient.Location = new System.Drawing.Point(3, 79);
            this.grpNewClient.Name = "grpNewClient";
            this.grpNewClient.Size = new System.Drawing.Size(610, 487);
            this.grpNewClient.TabIndex = 6;
            this.grpNewClient.TabStop = false;
            this.grpNewClient.Text = "Client Details";
            this.grpNewClient.Enter += new System.EventHandler(this.grpNewClient_Enter);
            // 
            // btnDeleteLogo
            // 
            this.btnDeleteLogo.Location = new System.Drawing.Point(527, 221);
            this.btnDeleteLogo.Name = "btnDeleteLogo";
            this.btnDeleteLogo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLogo.TabIndex = 42;
            this.btnDeleteLogo.Text = "Remove";
            this.btnDeleteLogo.UseVisualStyleBackColor = true;
            // 
            // btnLoadLogo
            // 
            this.btnLoadLogo.Location = new System.Drawing.Point(446, 221);
            this.btnLoadLogo.Name = "btnLoadLogo";
            this.btnLoadLogo.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLogo.TabIndex = 41;
            this.btnLoadLogo.Text = "Load ...";
            this.btnLoadLogo.UseVisualStyleBackColor = true;
            this.btnLoadLogo.Click += new System.EventHandler(this.btnLoadLogo_Click);
            // 
            // pboxEmail
            // 
            this.pboxEmail.Image = global::DPL_0002.Resource1.EmailLogo;
            this.pboxEmail.Location = new System.Drawing.Point(280, 274);
            this.pboxEmail.Name = "pboxEmail";
            this.pboxEmail.Size = new System.Drawing.Size(20, 20);
            this.pboxEmail.TabIndex = 40;
            this.pboxEmail.TabStop = false;
            // 
            // pboxFacebook
            // 
            this.pboxFacebook.Image = global::DPL_0002.Resource1.FacebookLogo;
            this.pboxFacebook.Location = new System.Drawing.Point(280, 300);
            this.pboxFacebook.Name = "pboxFacebook";
            this.pboxFacebook.Size = new System.Drawing.Size(20, 20);
            this.pboxFacebook.TabIndex = 39;
            this.pboxFacebook.TabStop = false;
            // 
            // pboxTwitter
            // 
            this.pboxTwitter.Image = global::DPL_0002.Resource1.TwitterLogo;
            this.pboxTwitter.Location = new System.Drawing.Point(280, 326);
            this.pboxTwitter.Name = "pboxTwitter";
            this.pboxTwitter.Size = new System.Drawing.Size(20, 20);
            this.pboxTwitter.TabIndex = 38;
            this.pboxTwitter.TabStop = false;
            // 
            // pboxSkype
            // 
            this.pboxSkype.Image = global::DPL_0002.Resource1.SkypeLogo;
            this.pboxSkype.Location = new System.Drawing.Point(280, 352);
            this.pboxSkype.Name = "pboxSkype";
            this.pboxSkype.Size = new System.Drawing.Size(20, 20);
            this.pboxSkype.TabIndex = 37;
            this.pboxSkype.TabStop = false;
            // 
            // pboxTel
            // 
            this.pboxTel.Image = global::DPL_0002.Resource1.TelephoneLogo;
            this.pboxTel.Location = new System.Drawing.Point(280, 248);
            this.pboxTel.Name = "pboxTel";
            this.pboxTel.Size = new System.Drawing.Size(20, 20);
            this.pboxTel.TabIndex = 36;
            this.pboxTel.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Skype";
            // 
            // txtSkype
            // 
            this.txtSkype.Enabled = false;
            this.txtSkype.Location = new System.Drawing.Point(165, 352);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(109, 20);
            this.txtSkype.TabIndex = 34;
            this.txtSkype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSkype_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Facebook";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Twitter";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Enabled = false;
            this.txtFacebook.Location = new System.Drawing.Point(165, 300);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(109, 20);
            this.txtFacebook.TabIndex = 31;
            this.txtFacebook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFacebook_KeyDown);
            // 
            // txtTwitter
            // 
            this.txtTwitter.Enabled = false;
            this.txtTwitter.Location = new System.Drawing.Point(165, 326);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(109, 20);
            this.txtTwitter.TabIndex = 30;
            this.txtTwitter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTwitter_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(165, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(109, 20);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(127, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Email";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Enabled = false;
            this.txtPostalCode.Location = new System.Drawing.Point(165, 222);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(56, 20);
            this.txtPostalCode.TabIndex = 27;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostalCode_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Postal Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Contact Person Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Contact Person Tel";
            // 
            // txtContactPersonSurname
            // 
            this.txtContactPersonSurname.Enabled = false;
            this.txtContactPersonSurname.Location = new System.Drawing.Point(165, 404);
            this.txtContactPersonSurname.Name = "txtContactPersonSurname";
            this.txtContactPersonSurname.Size = new System.Drawing.Size(109, 20);
            this.txtContactPersonSurname.TabIndex = 23;
            this.txtContactPersonSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactPersonSurname_KeyDown);
            // 
            // txtContactPersonTel
            // 
            this.txtContactPersonTel.Enabled = false;
            this.txtContactPersonTel.Location = new System.Drawing.Point(165, 430);
            this.txtContactPersonTel.Name = "txtContactPersonTel";
            this.txtContactPersonTel.Size = new System.Drawing.Size(109, 20);
            this.txtContactPersonTel.TabIndex = 22;
            this.txtContactPersonTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactPersonTel_KeyDown);
            // 
            // txtContactPersonName
            // 
            this.txtContactPersonName.Enabled = false;
            this.txtContactPersonName.Location = new System.Drawing.Point(165, 378);
            this.txtContactPersonName.Name = "txtContactPersonName";
            this.txtContactPersonName.Size = new System.Drawing.Size(109, 20);
            this.txtContactPersonName.TabIndex = 21;
            this.txtContactPersonName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactPersonName_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Contact Person Name";
            // 
            // txtCompanyTel
            // 
            this.txtCompanyTel.Enabled = false;
            this.txtCompanyTel.Location = new System.Drawing.Point(165, 248);
            this.txtCompanyTel.Name = "txtCompanyTel";
            this.txtCompanyTel.Size = new System.Drawing.Size(109, 20);
            this.txtCompanyTel.TabIndex = 19;
            this.txtCompanyTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyTel_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Company Tel";
            // 
            // cmbSuburb
            // 
            this.cmbSuburb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSuburb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSuburb.FormattingEnabled = true;
            this.cmbSuburb.Location = new System.Drawing.Point(165, 195);
            this.cmbSuburb.Name = "cmbSuburb";
            this.cmbSuburb.Size = new System.Drawing.Size(135, 21);
            this.cmbSuburb.TabIndex = 17;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(165, 167);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(135, 21);
            this.cmbCity.TabIndex = 16;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbProvince
            // 
            this.cmbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(165, 143);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(135, 21);
            this.cmbProvince.TabIndex = 15;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Suburb";
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(165, 116);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(135, 21);
            this.cmbCountry.TabIndex = 11;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            this.cmbCountry.SelectionChangeCommitted += new System.EventHandler(this.cmbCountry_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Country";
            // 
            // txtAddressLine3
            // 
            this.txtAddressLine3.Location = new System.Drawing.Point(165, 90);
            this.txtAddressLine3.Name = "txtAddressLine3";
            this.txtAddressLine3.Size = new System.Drawing.Size(135, 20);
            this.txtAddressLine3.TabIndex = 3;
            this.txtAddressLine3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddressLine3_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address Line3";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(165, 64);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(135, 20);
            this.txtAddressLine2.TabIndex = 2;
            this.txtAddressLine2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddressLine2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address Line2";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(165, 38);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(135, 20);
            this.txtAddressLine1.TabIndex = 1;
            this.txtAddressLine1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddressLine1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address Line1";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(165, 14);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(135, 20);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Name";
            // 
            // imgLogo
            // 
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.imgLogo.Location = new System.Drawing.Point(306, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(296, 202);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // ClientMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.grpClientSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpNewClient);
            this.Name = "ClientMaintenance";
            this.Size = new System.Drawing.Size(812, 598);
            this.grpClientSearch.ResumeLayout(false);
            this.grpNewClient.ResumeLayout(false);
            this.grpNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSkype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelClose;
        private System.Windows.Forms.GroupBox grpClientSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpNewClient;
        private System.Windows.Forms.TextBox txtAddressLine3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DataCat.Controls.ClientLookup clientLookup1;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbSuburb;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pboxEmail;
        private System.Windows.Forms.PictureBox pboxFacebook;
        private System.Windows.Forms.PictureBox pboxTwitter;
        private System.Windows.Forms.PictureBox pboxSkype;
        private System.Windows.Forms.PictureBox pboxTel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContactPersonSurname;
        private System.Windows.Forms.TextBox txtContactPersonTel;
        private System.Windows.Forms.TextBox txtContactPersonName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompanyTel;
        private System.Windows.Forms.Button btnDeleteLogo;
        private System.Windows.Forms.Button btnLoadLogo;

    }
}
