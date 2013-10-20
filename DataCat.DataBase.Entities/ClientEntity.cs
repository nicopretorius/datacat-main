using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataCat.Utilities;
using MySql.Data.MySqlClient;
using DataCat.Connection;

namespace DataCat.Database.Entities
{
    public class ClientEntity
    {
     
        #region Constructors

		public ClientEntity()
			: this(-1)
		{
		}       

		public ClientEntity(int inID)
		{
			if(inID != -1)
			{
					Load(inID);
					bModified = false;
			} else
					iD = -1;
		}

		public ClientEntity(object rawdata)
		{
			if(rawdata is ClientEntity)
			{
				ClientEntity data = rawdata as ClientEntity;

				iD = data.iD;
				modifiedDate = data.modifiedDate;
				deleted = data.deleted;
				userID = data.userID;
				companyName = data.companyName;
				countryID = data.countryID;
				provinceID = data.provinceID;
				cityID = data.cityID;
				suburbID = data.suburbID;
				postalCode = data.postalCode;
				addressLine1 = data.addressLine1;
				addressLine2 = data.addressLine2;
				addressLine3 = data.addressLine3;
				companyTel = data.companyTel;
				contactPersonName = data.contactPersonName;
				contactPersonSurname = data.contactPersonSurname;
                contactPersonTel = data.contactPersonTel;
				vatNo = data.vatNo;
				regNumber = data.regNumber;
				telNumber = data.telNumber;
				faxNumber = data.faxNumber;
				emailAddress = data.emailAddress;
				facebook = data.facebook;
				twitter = data.twitter;
				skype = data.skype;
				bModified = false;
			}
		}

		public ClientEntity(int inID, DateTime inModifiedDate, int inDeleted, int inUserID, string inCompanyName, int inCountryID, int inProvinceID, int inCityID, int inSuburbID, int inPostalCode, string inAddressLine1, string inAddressLine2, string inAddressLine3, string inCompanyTel, string inContactPersonName, string inContactPersonSurname,string inContactPersonTel, string inVatNo, string inRegNumber, string inTelNumber, string inFaxNumber, string inEmailAddress, string inFacebook, string inTwitter, string inSkype)
		{
			iD = inID;
			modifiedDate = inModifiedDate;
			deleted = inDeleted;
			userID = inUserID;
			companyName = inCompanyName;
			countryID = inCountryID;
			provinceID = inProvinceID;
			cityID = inCityID;
			suburbID = inSuburbID;
			postalCode = inPostalCode;
			addressLine1 = inAddressLine1;
			addressLine2 = inAddressLine2;
			addressLine3 = inAddressLine3;
			companyTel = inCompanyTel;
			contactPersonName = inContactPersonName;
			contactPersonSurname = inContactPersonSurname;
			vatNo = inVatNo;
			regNumber = inRegNumber;
			telNumber = inTelNumber;
			faxNumber = inFaxNumber;
			emailAddress = inEmailAddress;
			facebook = inFacebook;
			twitter = inTwitter;
			skype = inSkype;
			bModified = false;
		}

		#endregion

		#region Fields

		int iD = 0;
		DateTime modifiedDate = DateTime.Now;
		int deleted = 0;
		int userID = 0;
		string companyName = "";
		int countryID = 0;
		int provinceID = 0;
		int cityID = 0;
		int suburbID = 0;
		int postalCode = 0;
		string addressLine1 = "";
		string addressLine2 = "";
		string addressLine3 = "";
		string companyTel = "";
		string contactPersonName = "";
		string contactPersonSurname = "";
        string contactPersonTel = "";
		string vatNo = "";
		string regNumber = "";
		string telNumber = "";
		string faxNumber = "";
		string emailAddress = "";
		string facebook = "";
		string twitter = "";
		string skype = "";
        int logoImageID = -1;

        public int LogoID
        {
            get { return logoImageID; }
            set { logoImageID = value; }
        }
		bool bModified = false;

		#endregion

		#region Properties

		public bool Modified
		{
			get
			{
				return bModified;
			}
		}
		

		public int ID
		{
			get
			{
				return iD;
			}
			set
			{
				if(iD != value)
				{
					iD = value;
					bModified = true;
				}
			}
		}

		public DateTime ModifiedDate
		{
			get
			{
				return modifiedDate;
			}
			set
			{
				if(modifiedDate != value)
				{
					modifiedDate = value;
					bModified = true;
				}
			}
		}

		public int Deleted
		{
			get
			{
				return deleted;
			}
			set
			{
				if(deleted != value)
				{
					deleted = value;
					bModified = true;
				}
			}
		}

		public int UserID
		{
			get
			{
				return userID;
			}
			set
			{
				if(userID != value)
				{
					userID = value;
					bModified = true;
				}
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set
			{
				if(companyName != value)
				{
					companyName = value;
					bModified = true;
				}
			}
		}

		public int CountryID
		{
			get
			{
				return countryID;
			}
			set
			{
				if(countryID != value)
				{
					countryID = value;
					bModified = true;
				}
			}
		}

		public int ProvinceID
		{
			get
			{
				return provinceID;
			}
			set
			{
				if(provinceID != value)
				{
					provinceID = value;
					bModified = true;
				}
			}
		}

		public int CityID
		{
			get
			{
				return cityID;
			}
			set
			{
				if(cityID != value)
				{
					cityID = value;
					bModified = true;
				}
			}
		}

		public int SuburbID
		{
			get
			{
				return suburbID;
			}
			set
			{
				if(suburbID != value)
				{
					suburbID = value;
					bModified = true;
				}
			}
		}

		public int PostalCode
		{
			get
			{
				return postalCode;
			}
			set
			{
				if(postalCode != value)
				{
					postalCode = value;
					bModified = true;
				}
			}
		}

		public string AddressLine1
		{
			get
			{
				return addressLine1;
			}
			set
			{
				if(addressLine1 != value)
				{
					addressLine1 = value;
					bModified = true;
				}
			}
		}

		public string AddressLine2
		{
			get
			{
				return addressLine2;
			}
			set
			{
				if(addressLine2 != value)
				{
					addressLine2 = value;
					bModified = true;
				}
			}
		}

		public string AddressLine3
		{
			get
			{
				return addressLine3;
			}
			set
			{
				if(addressLine3 != value)
				{
					addressLine3 = value;
					bModified = true;
				}
			}
		}

		public string CompanyTel
		{
			get
			{
				return companyTel;
			}
			set
			{
				if(companyTel != value)
				{
					companyTel = value;
					bModified = true;
				}
			}
		}

		public string ContactPersonName
		{
			get
			{
				return contactPersonName;
			}
			set
			{
				if(contactPersonName != value)
				{
					contactPersonName = value;
					bModified = true;
				}
			}
		}

		public string ContactPersonSurname
		{
			get
			{
				return contactPersonSurname;
			}
			set
			{
				if(contactPersonSurname != value)
				{
					contactPersonSurname = value;
					bModified = true;
				}
			}
		}

        public string ContactPersonTel
        {
            get
            {
                return contactPersonTel;
            }
            set
            {
                if (contactPersonTel != value)
                {
                    contactPersonTel = value;
                    bModified = true;
                }
            }
        }

		public string VatNo
		{
			get
			{
				return vatNo;
			}
			set
			{
				if(vatNo != value)
				{
					vatNo = value;
					bModified = true;
				}
			}
		}

		public string RegNumber
		{
			get
			{
				return regNumber;
			}
			set
			{
				if(regNumber != value)
				{
					regNumber = value;
					bModified = true;
				}
			}
		}

		public string TelNumber
		{
			get
			{
				return telNumber;
			}
			set
			{
				if(telNumber != value)
				{
					telNumber = value;
					bModified = true;
				}
			}
		}

		public string FaxNumber
		{
			get
			{
				return faxNumber;
			}
			set
			{
				if(faxNumber != value)
				{
					faxNumber = value;
					bModified = true;
				}
			}
		}

		public string EmailAddress
		{
			get
			{
				return emailAddress;
			}
			set
			{
				if(emailAddress != value)
				{
					emailAddress = value;
					bModified = true;
				}
			}
		}

		public string Facebook
		{
			get
			{
				return facebook;
			}
			set
			{
				if(facebook != value)
				{
					facebook = value;
					bModified = true;
				}
			}
		}

		public string Twitter
		{
			get
			{
				return twitter;
			}
			set
			{
				if(twitter != value)
				{
					twitter = value;
					bModified = true;
				}
			}
		}

		public string Skype
		{
			get
			{
				return skype;
			}
			set
			{
				if(skype != value)
				{
					skype = value;
					bModified = true;
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Clone this instance.
		/// </summary>
		public object Clone()
		{
			return new ClientEntity(this);
		}

		/// <summary>
		/// Load the specified _ID.
		/// </summary>
		/// <param name=_ID>
		/// iD of detail to load.
		/// </summary>
		public bool Load(int inID)
		{
			try
			{ 
				using (MySqlDataReader reader = Connection.Connection.ExecureReader(@"
					SELECT 
						ID, 
						ModifiedDate, 
						Deleted, 
						UserID, 
						CompanyName, 
						CountryID, 
						ProvinceID, 
						CityID, 
						SuburbID, 
						PostalCode, 
						AddressLine1, 
						AddressLine2, 
						AddressLine3, 
						CompanyTel, 
						ContactPersonName, 
						ContactPersonSurname, 
						VatNo, 
						RegNumber, 
						TelNumber, 
						FaxNumber, 
						EmailAddress, 
						Facebook, 
						Twitter, 
						Skype,
                        LogoImageID
					FROM Client
					WHERE iD = " + inID.ToString()))
                 {
                     while (reader.Read())
                     {
                         iD = Convert.ToInt32(reader["ID"]);
                         modifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                         deleted = Convert.ToInt32(reader["Deleted"]);
                         userID = Convert.ToInt32(reader["UserID"]);
                         companyName = Convert.ToString(reader["CompanyName"]);
                         countryID = Convert.ToInt32(reader["CountryID"]);
                         provinceID = Convert.ToInt32(reader["ProvinceID"]);
                         cityID = Convert.ToInt32(reader["CityID"]);
                         suburbID = Convert.ToInt32(reader["SuburbID"]);
                         postalCode = Convert.ToInt32(reader["PostalCode"]);
                         addressLine1 = Convert.ToString(reader["AddressLine1"]);
                         addressLine2 = Convert.ToString(reader["AddressLine2"]);
                         addressLine3 = Convert.ToString(reader["AddressLine3"]);
                         companyTel = Convert.ToString(reader["CompanyTel"]);
                         contactPersonName = Convert.ToString(reader["ContactPersonName"]);
                         contactPersonSurname = Convert.ToString(reader["ContactPersonSurname"]);
                         vatNo = Convert.ToString(reader["VatNo"]);
                         regNumber = Convert.ToString(reader["RegNumber"]);
                         telNumber = Convert.ToString(reader["TelNumber"]);
                         faxNumber = Convert.ToString(reader["FaxNumber"]);
                         emailAddress = Convert.ToString(reader["EmailAddress"]);
                         facebook = Convert.ToString(reader["Facebook"]);
                         twitter = Convert.ToString(reader["Twitter"]);
                         skype = Convert.ToString(reader["Skype"]);
                         logoImageID = Convert.ToInt32(reader["LogoImageID"]);
                     }
				    bModified = false;
				    return true;
                }
			}
			catch(Exception ex)
			{
				Log.Error(ex.Message);
				return false;
			}
		}

		/// <summary>
		/// Creates new entry
		/// </summary>
		private bool Create()
		{
			try
			{
				Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Create_Client");
			
				proc.AddInputParameterWithValue("inID", iD); 
				proc.AddInputParameterWithValue("inDeleted", deleted); 
				proc.AddInputParameterWithValue("inUserID", userID); 
				proc.AddInputParameterWithValue("inCompanyName", companyName); 
				proc.AddInputParameterWithValue("inCountryID", countryID); 
				proc.AddInputParameterWithValue("inProvinceID", provinceID); 
				proc.AddInputParameterWithValue("inCityID", cityID); 
				proc.AddInputParameterWithValue("inSuburbID", suburbID); 
				proc.AddInputParameterWithValue("inPostalCode", postalCode); 
				proc.AddInputParameterWithValue("inAddressLine1", addressLine1); 
				proc.AddInputParameterWithValue("inAddressLine2", addressLine2); 
				proc.AddInputParameterWithValue("inAddressLine3", addressLine3); 
				proc.AddInputParameterWithValue("inCompanyTel", companyTel); 
				proc.AddInputParameterWithValue("inContactPersonName", contactPersonName); 
				proc.AddInputParameterWithValue("inContactPersonSurname", contactPersonSurname);
                proc.AddInputParameterWithValue("inContactPersonTel", contactPersonTel); 
				proc.AddInputParameterWithValue("inVatNo", vatNo); 
				proc.AddInputParameterWithValue("inRegNumber", regNumber); 
				proc.AddInputParameterWithValue("inTelNumber", telNumber); 
				proc.AddInputParameterWithValue("inFaxNumber", faxNumber); 
				proc.AddInputParameterWithValue("inEmailAddress", emailAddress); 
				proc.AddInputParameterWithValue("inFacebook", facebook); 
				proc.AddInputParameterWithValue("inTwitter", twitter); 
				proc.AddInputParameterWithValue("inSkype", skype);
                proc.AddInputParameterWithValue("inLogoImageID", logoImageID); 
				proc.AddOutParameter("outID", MySql.Data.MySqlClient.MySqlDbType.Int32);
                proc.AddInputParameterWithValue("inLogoImageID", logoImageID); 
				if(proc.Execute())
				{
					iD = Convert.ToInt32(proc.GetParameterValue("outID"));
					bModified = false;
					return true;
				} else
					return false;
				
			}
			catch(Exception ex)
			{
				Log.Error(ex.Message);
				return false;
			}
		}

		/// <summary>
		/// Updates an existing entry in database.
		/// </summary>
		private bool Update()
		{
			try
			{ 
				Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Update_Client");
				
				proc.AddInputParameterWithValue("inID", iD); 				
				proc.AddInputParameterWithValue("inDeleted", deleted); 
				proc.AddInputParameterWithValue("inUserID", userID); 
				proc.AddInputParameterWithValue("inCompanyName", companyName); 
				proc.AddInputParameterWithValue("inCountryID", countryID); 
				proc.AddInputParameterWithValue("inProvinceID", provinceID); 
				proc.AddInputParameterWithValue("inCityID", cityID); 
				proc.AddInputParameterWithValue("inSuburbID", suburbID); 
				proc.AddInputParameterWithValue("inPostalCode", postalCode); 
				proc.AddInputParameterWithValue("inAddressLine1", addressLine1); 
				proc.AddInputParameterWithValue("inAddressLine2", addressLine2); 
				proc.AddInputParameterWithValue("inAddressLine3", addressLine3); 
				proc.AddInputParameterWithValue("inCompanyTel", companyTel); 
				proc.AddInputParameterWithValue("inContactPersonName", contactPersonName); 
				proc.AddInputParameterWithValue("inContactPersonSurname", contactPersonSurname);
                proc.AddInputParameterWithValue("inContactPersonTel", contactPersonTel); 
				proc.AddInputParameterWithValue("inVatNo", vatNo); 
				proc.AddInputParameterWithValue("inRegNumber", regNumber); 
				proc.AddInputParameterWithValue("inTelNumber", telNumber); 
				proc.AddInputParameterWithValue("inFaxNumber", faxNumber); 
				proc.AddInputParameterWithValue("inEmailAddress", emailAddress); 
				proc.AddInputParameterWithValue("inFacebook", facebook); 
				proc.AddInputParameterWithValue("inTwitter", twitter); 
				proc.AddInputParameterWithValue("inSkype", skype);
                proc.AddInputParameterWithValue("inLogoImageID", logoImageID); 
				if (proc.Execute())
				{
						
					bModified = false;
					return true;
				} else
					return false;
				
			}
			catch(Exception ex)
			{
				Log.Error(ex.Message);
				return false;
			}
		}

		/// <summary>
		/// Saves this instance.
		/// </summary>
		public bool Save()
		{
			try
			{
				if(iD == -1)
					return Create();
				else
					return Update();
			}
			catch (Exception ex)
			{
				Log.Error(ex.Message);
				return false;
			}
		}

		#endregion

        

    }
}
