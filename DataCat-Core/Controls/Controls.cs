using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataCat.Utilities;


    namespace DataCat.Controls
    {

        public static class ListData
        {
            public static void ForceReloadListData()
            {
                reloadCities = true;
                reloadCountries = true;
                reloadProvinces = true;
                reloadSuburbs = true;
            }

            private static bool reloadCountries = true;
            private static bool reloadProvinces = true;
            private static bool reloadCities = true;
            private static bool reloadSuburbs = true;
            private static bool reloadProjectTypes = true;
            private static bool reloadGender = true;
            private static bool reloadMaritalStatus = true;
            private static bool reloadNationality = true;
            private static bool reloadLanguage = true;
  
            private static List<ComboBoxItemWithParent> LoadData(string SQL)
            {
                List<ComboBoxItemWithParent> list = new List<ComboBoxItemWithParent>();
                using (MySql.Data.MySqlClient.MySqlDataReader reader = Connection.Connection.ExecureReader(SQL))
                {
                    while (reader.Read())
                    {
                        ComboBoxItemWithParent cmbItem = new ComboBoxItemWithParent(reader[0].ToString(), reader[1], Convert.ToInt32(reader[2]));
                        list.Add(cmbItem);
                    }
                }
                return list;
            }
            

            private static System.Collections.Generic.List<ComboBoxItemWithParent> SuburbData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> CityData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> ProvinceData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> CountryData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> ProjectTypeData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> GenderData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> MaritalStatusData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> NationalityData;
            private static System.Collections.Generic.List<ComboBoxItemWithParent> LanguageData;


            private static void ReloadGender()
            {
                GenderData = LoadData("SELECT Name,ID,'1' FROM ref_Gender;");
                reloadGender = false;
            }

            private static void ReloadMaritalStatus()
            {
                MaritalStatusData = LoadData("SELECT Name,ID,'1' FROM ref_MaritalStatus;");
                reloadMaritalStatus = false;
            }

            private static void ReloadNationality()
            {
                NationalityData = LoadData("SELECT Name,ID,'1' FROM ref_Nationality;");
                reloadNationality = false;
            }

            private static void ReloadLanguage()
            {
                LanguageData = LoadData("SELECT Name,ID,'1' FROM ref_Language;");
                reloadLanguage = false;
            }



            private static void ReloadSuburbs()
            {
                SuburbData = LoadData("SELECT Name,ID,ParentID FROM ref_Suburb;");
                reloadSuburbs = false;
            }

            private static void ReloadProjectTypes()
            {
                ProjectTypeData = LoadData("SELECT Name,ID,'1' FROM ref_ProjectType;");
                reloadProjectTypes    = false;
            }

            private static void ReloadCities()
            {
                CityData = LoadData("SELECT Name,ID,ParentID  FROM ref_City;");
                reloadCities = false;
            }

            private static void ReloadProvinces()
            {
                ProvinceData = LoadData("SELECT Name,ID,ParentID FROM ref_Province;");
                reloadProvinces = false;
            }

            private static void ReloadCountries()
            {
                CountryData = LoadData("SELECT Name,ID,'1' FROM ref_Country;");
                reloadCountries = false;
            }


            public static List<ComboBoxItem> GetCountries()
            {
                if (reloadCountries) ReloadCountries();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboBoxItemWithParent in CountryData)
                {
                    lst.Add(comboBoxItemWithParent);
                }
                return lst;
            }

            public static List<ComboBoxItem> GetLanguage()
            {
                if (reloadLanguage) ReloadLanguage();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboboxItem in LanguageData)
                {
                    lst.Add(comboboxItem);
                }
                return lst;
            }

            public static List<ComboBoxItem> GetMaritalStatus()
            {
                if (reloadMaritalStatus) ReloadMaritalStatus();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboboxItem in MaritalStatusData)
                {
                    lst.Add(comboboxItem);
                }
                return lst;
            }

            public static List<ComboBoxItem> GetNationality()
            {
                if (reloadNationality) ReloadNationality();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboboxItem in NationalityData)
                {
                    lst.Add(comboboxItem);
                }
                return lst;
            }

            public static List<ComboBoxItem> GetGender()
            {
                if (reloadGender) ReloadGender();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboboxItem in GenderData)
                {
                    lst.Add(comboboxItem);
                }
                return lst;
            }


            public static List<ComboBoxItem> GetProjectTypes()
            {
                if (reloadProjectTypes) ReloadProjectTypes  ();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboboxItem in ProjectTypeData)
                {
                    lst.Add(comboboxItem);
                }
                return lst;
            }


            public static List<ComboBoxItem> GetSuburbs(int CityID)
            {
                if (reloadSuburbs) ReloadSuburbs();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboBoxItemWithParent in SuburbData)
                {
                    if (comboBoxItemWithParent.ParentID == CityID)
                    {
                        lst.Add(comboBoxItemWithParent);
                    }
                }
                return lst;
            }
            public static List<ComboBoxItem> GetCities(int ProvinceID)
            {
                if (reloadCities) ReloadCities();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboBoxItemWithParent in CityData)
                {
                    if (comboBoxItemWithParent.ParentID == ProvinceID)
                    {
                        lst.Add(comboBoxItemWithParent);
                    }
                }
                return lst;
            }
            public static List<ComboBoxItem> GetProvinces(int CountryID)
            {
                if (reloadProvinces) ReloadProvinces();
                List<ComboBoxItem> lst = new List<ComboBoxItem>();
                foreach (var comboBoxItemWithParent in ProvinceData)
                {
                    if (comboBoxItemWithParent.ParentID == CountryID)
                    {
                        lst.Add(comboBoxItemWithParent);
                    }
                }
                return lst;
            }

        }
    }

