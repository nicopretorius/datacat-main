using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataCat.Plugins;
using DataCat.Utilities;
using DataCat.Connection;
using MySql.Data.MySqlClient;
using DataCat.Database.Entities;
using System.Threading;

namespace DPL_0002
{
    public partial class ClientMaintenance : UserControl,IPlugin
    {
        #region Fields

        enum eEditState
        {
            Cancel,
            New,
            Edit
        }

        #endregion
        ClientEntity curClient = new ClientEntity();

        public ClientMaintenance()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            EditState(eEditState.Cancel);
   
        }

        private void EditState(eEditState State)
        {
            if (State == eEditState.Cancel)
            {

                ClearControls();
                txtAddressLine1.Enabled = false;
                txtAddressLine2.Enabled = false;
                txtAddressLine3.Enabled = false;
                txtCompanyName.Enabled = false;
                txtCompanyTel.Enabled = false;
                txtContactPersonName.Enabled = false;
                txtContactPersonSurname.Enabled = false;
                txtContactPersonTel.Enabled = false;
                txtEmail.Enabled = false;
                txtFacebook.Enabled = false;
                txtPostalCode.Enabled = false;
                txtSkype.Enabled = false;
                txtTwitter.Enabled = false;
                cmbCity.Enabled = false;
                cmbCountry.Enabled = false;
                cmbProvince.Enabled = false;
                cmbSuburb.Enabled = false;

                clientLookup1.GrabFocus();

                clientLookup1.Enabled = true;
                btnCancelClose.Enabled = false;
                btnSave.Enabled = false;
                btnNew.Enabled = true;
            }

            if (State == eEditState.Edit)
            {
                ClearControls();
                txtAddressLine1.Enabled = true;
                txtAddressLine2.Enabled = true;
                txtAddressLine3.Enabled = true;
                txtCompanyName.Enabled = true;
                txtCompanyTel.Enabled = true;
                txtContactPersonName.Enabled = true;
                txtContactPersonSurname.Enabled = true;
                txtContactPersonTel.Enabled = true;
                txtEmail.Enabled = true;
                txtFacebook.Enabled = true;
                txtPostalCode.Enabled = true;
                txtSkype.Enabled = true;
                txtTwitter.Enabled = true;
                cmbCity.Enabled = true;
                cmbCountry.Enabled = true;
                cmbProvince.Enabled = true;
                cmbSuburb.Enabled = true;
                clientLookup1.Enabled = false;
                btnCancelClose.Enabled = true;
                btnSave.Enabled = true;
                btnNew.Enabled = false;
            }

            if (State == eEditState.New)
            {
                ClearControls();
                txtAddressLine1.Enabled = true;
                txtAddressLine2.Enabled = true;
                txtAddressLine3.Enabled = true;
                txtCompanyName.Enabled = true;
                txtCompanyTel.Enabled = true;
                txtContactPersonName.Enabled = true;
                txtContactPersonSurname.Enabled = true;
                txtContactPersonTel.Enabled = true;
                txtEmail.Enabled = true;
                txtFacebook.Enabled = true;
                txtPostalCode.Enabled = true;
                txtSkype.Enabled = true;
                txtTwitter.Enabled = true;
                cmbCity.Enabled = true;
                cmbCountry.Enabled = true;
                cmbProvince.Enabled = true;
                cmbSuburb.Enabled = true;
                txtCompanyName.Focus();
                clientLookup1.Enabled = false;
                btnCancelClose.Enabled = true;
                btnSave.Enabled = true;
                btnNew.Enabled = false; 
            }
        }




        private void PopulateCountry()
        {
            cmbCountry.DataSource = DataCat.Controls.ListData.GetCountries();
        }

        private void grpNewClient_Enter(object sender, EventArgs e)
        {

        }

        private void clientLookup1_ClientSelected(DataCat.Database.Entities.ClientEntity SelectedClient)
        {
            curClient = SelectedClient;
            EditState(eEditState.Edit);
            PopulateCurrentClient();
        }

        private void PopulateProvince()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbCountry).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbCountry.SelectedItem as ComboBoxItem;
                int countryID = Convert.ToInt32(item.HiddenValue);
                cmbProvince.DataSource = DataCat.Controls.ListData.GetProvinces(countryID);
            }
        }

        private void PopulateCity()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbProvince).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbProvince.SelectedItem as ComboBoxItem;
                int ProvinceID = Convert.ToInt32(item.HiddenValue);

                cmbCity.DataSource = DataCat.Controls.ListData.GetCities(ProvinceID);

            }
        }

        private void PopulateSuburb()
        {
               
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbCity).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbCity.SelectedItem as ComboBoxItem;
                int CityID = Convert.ToInt32(item.HiddenValue);

                cmbSuburb.DataSource = DataCat.Controls.ListData.GetSuburbs(CityID);

            }
        }


        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProvince();

            cmbProvince.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbSuburb.SelectedIndex = -1;
        
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCity();

                cmbCity.SelectedIndex = -1;
                cmbSuburb.SelectedIndex = -1;
       
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSuburb();
 
                cmbSuburb.SelectedIndex = -1;
  
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            curClient = new ClientEntity();
            EditState(eEditState.New);
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddressLine1.Focus();
            }
        }

        private void txtAddressLine1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddressLine2.Focus();
            }
        }

        private void txtAddressLine2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddressLine3.Focus();
            }
        }

        private void txtAddressLine3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCountry.Focus();
            }
        }     

        private void txtPostalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompanyTel.Focus();
            }
        }

        private void txtCompanyTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFacebook.Focus();
            }
        }

        private void txtFacebook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTwitter.Focus();
            }
        }

        private void txtTwitter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSkype.Focus();
            }
        }

        private void txtSkype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactPersonName.Focus();
            }
        }

        private void txtContactPersonName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactPersonSurname.Focus();
            }
        }

        private void txtContactPersonSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContactPersonTel.Focus();
            }
        }

        private void txtContactPersonTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbProvince.Focus();
        }

        private void ClearControls()
        {
            try
            {
                cmbCity.Items.Clear();
                cmbSuburb.Items.Clear();
                cmbProvince.Items.Clear();
                cmbCountry.Items.Clear();
                PopulateCountry();
            }
            catch
            {
            }
            foreach (Control txt in grpNewClient.Controls)
            {
                if (txt is TextBox) (txt as TextBox).Text = "";
                if (txt is ComboBox) (txt as ComboBox).Text = "";
            }
            imgLogo.Image = null;
            LogoChanged = false;
        }

        string imgFileName = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LogoChanged)
            {
                int logoID = DataCat.Connection.Connection.SaveImage(Image.FromFile(imgFileName));
                curClient.LogoID = logoID;
                
            }
            UpdateCurrentClient();
            curClient.Save();
            LogoChanged = false;
            ClearControls();
            EditState(eEditState.Cancel);
        }

        private void PopulateCurrentClient()
        {
            try
            {

                txtAddressLine1.Text = curClient.AddressLine1;
                txtAddressLine2.Text = curClient.AddressLine2;
                txtAddressLine3.Text = curClient.AddressLine3;
                txtEmail.Text = curClient.EmailAddress;
                txtFacebook.Text = curClient.Facebook;
                txtCompanyName.Text = curClient.CompanyName;
                txtCompanyTel.Text = curClient.CompanyTel;
                txtContactPersonName.Text = curClient.ContactPersonName;
                txtContactPersonSurname.Text = curClient.ContactPersonSurname;

                //    txtFax.Text=curClient.FaxNumber; 
                txtPostalCode.Text = curClient.PostalCode.ToString();

                //curClient.RegNumber = 
                txtSkype.Text = curClient.Skype;
                txtCompanyTel.Text = curClient.TelNumber;
                txtTwitter.Text = curClient.Twitter;
                //curClient.UserID = Connection.
                //curClient.VatNo = 
                PopulateCountry();
                DataCat.Utilities.Utilities.SetComboBoxId(cmbCountry, curClient.CountryID.ToString());

              
                DataCat.Utilities.Utilities.SetComboBoxId(cmbProvince,curClient.ProvinceID.ToString());
                DataCat.Utilities.Utilities.SetComboBoxId(cmbCity, curClient.CityID.ToString());
                DataCat.Utilities.Utilities.SetComboBoxId(cmbSuburb, curClient.SuburbID.ToString());
                Thread t = new Thread(PopulateLogo);
                t.Start();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {

            }
        }

        private void PopulateLogo()
        {
            if (curClient.LogoID > 0)
            {
                Image img = DataCat.Connection.Connection.GetImage(curClient.LogoID);
                imgLogo.Image = img;
            }
        }

        private void UpdateCurrentClient()
        {
            curClient.AddressLine1 = txtAddressLine1.Text;
            curClient.AddressLine2 = txtAddressLine2.Text;
            curClient.AddressLine3 = txtAddressLine3.Text;
            curClient.EmailAddress = txtEmail.Text;
            curClient.Facebook = txtFacebook.Text;
            curClient.CompanyName = txtCompanyName.Text;
            curClient.CompanyTel = txtCompanyTel.Text;
            curClient.ContactPersonName = txtContactPersonName.Text;
            curClient.ContactPersonSurname = txtContactPersonName.Text;
            curClient.ContactPersonTel = txtContactPersonTel.Text;
            curClient.TelNumber = txtContactPersonTel.Text;
            //   curClient.FaxNumber = curClient.FaxNumber;
            //   curClient.RegNumber = 
            //   curClient.UserID = Connection.
            curClient.PostalCode = Convert.ToInt32(txtPostalCode.Text);
            

            curClient.Skype = txtSkype.Text;

            curClient.CountryID = Convert.ToInt32(DataCat.Utilities.Utilities.GetComboBoxSelection(cmbCountry).HiddenValue);
            curClient.ProvinceID = Convert.ToInt32(DataCat.Utilities.Utilities.GetComboBoxSelection(cmbProvince).HiddenValue);
            curClient.CityID = Convert.ToInt32(DataCat.Utilities.Utilities.GetComboBoxSelection(cmbCity).HiddenValue);            
            curClient.SuburbID = Convert.ToInt32(DataCat.Utilities.Utilities.GetComboBoxSelection(cmbSuburb).HiddenValue);
            curClient.TelNumber = txtCompanyTel.Text;
            curClient.Twitter = txtTwitter.Text;
 
            //curClient.VatNo = 
            
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
                
            EditState(eEditState.Cancel);
        }

        private void btnNewPic_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnNewPic_Click(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private bool LogoChanged = false;

        private void btnLoadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgFileName = dlg.FileName;
                imgLogo.Image = Image.FromFile(dlg.FileName);
                LogoChanged = true;
            }

            dlg.Dispose();
        }
    }
}
