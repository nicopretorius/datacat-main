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

namespace DPL_0003
{
    public partial class MaintainPerson : UserControl,IPlugin
    {
        
        public MaintainPerson()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            ClearAll();
            cmbGender.DataSource = DataCat.Controls.ListData.GetGender();        
        }

        private void ClearAll()
        {
            try
            {
                cmbPhysicalCity.Items.Clear();
                cmbPhysicalSuburb.Items.Clear();
                cmbPhysicalProvince.Items.Clear();
                cmbPhysicalCountry.Items.Clear();
                cmbPostalCity.Items.Clear();
                cmbPostalSuburb.Items.Clear();
                cmbPostalProvince.Items.Clear();
                cmbPostalCountry.Items.Clear();
                PopulatePhysicalCountry();
                PopulatePostalCountry();
            }
            catch
            {
            }

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtSurname.Text = "";
            txtIDNumber.Text = "";
            cmbGender.Text = "";
            cmbLanguage.Text = "";
            cmbNationality.Text = "";
            cmbMaritialStatus.Text = "";
            txtCellNumber.Text = "";
            txtTelNumber.Text = "";
            txtEmail.Text = "";
            txtFaxNumber.Text = "";
            txtWorkTel.Text = "";
            txtEmployerCompanyName.Text = "";

            txtPhysicalStreetName.Text = "";
            txtPhysicalStreetNumber.Text = "";
            cmbPhysicalCity.SelectedIndex = -1;
            txtPhysicalPostalCode.Text = "";

            txtPostalStreetName.Text = "";
            txtPostalStreetNumber.Text = "";
            cmbPostalCity.SelectedIndex = -1;
            txtPostalPostalCode.Text = "";
        }       

       // private void PopulatecmbGender

        private void MaintainPerson_Load(object sender, EventArgs e)
        {

        }

        private void PopulatePhysicalCountry()
        {
            cmbPhysicalCountry.DataSource = DataCat.Controls.ListData.GetCountries();
        }

        private void PopulatePhysicalProvince()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPhysicalCountry).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPhysicalCountry.SelectedItem as ComboBoxItem;
                int countryID = Convert.ToInt32(item.HiddenValue);
                cmbPhysicalProvince.DataSource = DataCat.Controls.ListData.GetProvinces(countryID);
            }
        }

        private void PopulatePhysicalCity()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPhysicalProvince).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPhysicalProvince.SelectedItem as ComboBoxItem;
                int ProvinceID = Convert.ToInt32(item.HiddenValue);

                cmbPhysicalCity.DataSource = DataCat.Controls.ListData.GetCities(ProvinceID);

            }
        }

        private void PopulatePhysicalSuburb()
        {

            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPhysicalCity).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPhysicalCity.SelectedItem as ComboBoxItem;
                int CityID = Convert.ToInt32(item.HiddenValue);

                cmbPhysicalSuburb.DataSource = DataCat.Controls.ListData.GetSuburbs(CityID);

            }
        }

        private void PopulatePostalCountry()
        {
            cmbPostalCountry.DataSource = DataCat.Controls.ListData.GetCountries();
        }

        private void PopulatePostalProvince()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPostalCountry).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPostalCountry.SelectedItem as ComboBoxItem;
                int countryID = Convert.ToInt32(item.HiddenValue);
                cmbPostalProvince.DataSource = DataCat.Controls.ListData.GetProvinces(countryID);
            }
        }

        private void PopulatePostalCity()
        {
            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPostalProvince).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPostalProvince.SelectedItem as ComboBoxItem;
                int ProvinceID = Convert.ToInt32(item.HiddenValue);

                cmbPostalCity.DataSource = DataCat.Controls.ListData.GetCities(ProvinceID);

            }
        }

        private void PopulatePostalSuburb()
        {

            if (Convert.ToInt32(Utilities.GetComboBoxSelection(cmbPostalCity).HiddenValue) > 0)
            {
                ComboBoxItem item = cmbPostalCity.SelectedItem as ComboBoxItem;
                int CityID = Convert.ToInt32(item.HiddenValue);

                cmbPostalSuburb.DataSource = DataCat.Controls.ListData.GetSuburbs(CityID);

            }
        }

        private void cmbPhysicalCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePhysicalProvince();

            cmbPhysicalProvince.SelectedIndex = -1;
            cmbPhysicalCity.SelectedIndex = -1;
            cmbPhysicalSuburb.SelectedIndex = -1;
        }

        private void cmbPhysicalProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePhysicalCity();

            cmbPhysicalCity.SelectedIndex = -1;
            cmbPhysicalSuburb.SelectedIndex = -1;
        }

        private void cmbPhysicalCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePhysicalSuburb();

            cmbPhysicalSuburb.SelectedIndex = -1;
        }

        private void cmbPhysicalSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPostalCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePostalProvince();

            cmbPostalProvince.SelectedIndex = -1;
            cmbPostalCity.SelectedIndex = -1;
            cmbPostalSuburb.SelectedIndex = -1;
        }

        private void cmbPostalProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePostalCity();

            cmbPostalCity.SelectedIndex = -1;
            cmbPostalSuburb.SelectedIndex = -1;
        }

        private void cmbPostalCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePostalSuburb();

            cmbPostalSuburb.SelectedIndex = -1;
        }

        private void cmbPostalSuburb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PersonEntity entity = new PersonEntity();

            entity.FirstName = txtFirstName.Text;
            entity.SecondName = txtSecondName.Text;
            entity.Surname = txtSurname.Text;
            entity.IDNumber = txtIDNumber.Text;
            entity.GenderID = cmbGender.SelectedIndex;
            entity.LanguageID = cmbLanguage.SelectedIndex;
            // entity.NationalityID = cmbNationality.SelectedIndex;// Changed Entitys nationality id to int
            entity.MaritalStatusID = cmbMaritialStatus.SelectedIndex;
            entity.CellNumber = txtCellNumber.Text;
            entity.TelNumber = txtTelNumber.Text;
            entity.EmailAddress = txtEmail.Text;
            entity.EmployerCompany = txtEmployerCompanyName.Text;
            entity.PhysicalAddressStreetName = txtPhysicalStreetName.Text;
            entity.PhysicalAddressStreetNumber = txtPhysicalStreetNumber.Text;
        }
    }
}
