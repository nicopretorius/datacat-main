using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataCat.Utilities;
using MySql.Data.MySqlClient;
using DataCat.Connection;

namespace DataCat.Database.Entities
{
    public class PersonEntity
    {
        #region Constructors

        public PersonEntity()
            : this(-1)
        {
        }

        public PersonEntity(int inID)
        {
            if (inID != -1)
            {
                Load(inID);
                bModified = false;
            }
            else
                iD = -1;
        }

        public PersonEntity(object rawdata)
        {
            if (rawdata is PersonEntity)
            {
                PersonEntity data = rawdata as PersonEntity;

                iD = data.iD;
                userID = data.userID;
                modifiedDate = data.modifiedDate;
                deleted = data.deleted;
                firstName = data.firstName;
                secondName = data.secondName;
                surname = data.surname;
                iDNumber = data.iDNumber;
                genderID = data.genderID;
                languageID = data.languageID;
                nationalityID = data.nationalityID;
                maritalStatusID = data.maritalStatusID;
                cellNumber = data.cellNumber;
                telNumber = data.telNumber;
                emailAddress = data.emailAddress;
                fax = data.fax;
                workTelNumber = data.workTelNumber;
                employerCompany = data.employerCompany;
                physicalAddressStreetName = data.physicalAddressStreetName;
                physicalAddressStreetNumber = data.physicalAddressStreetNumber;
                physicalAddressSuburbID = data.physicalAddressSuburbID;
                physicalAddressCityID = data.physicalAddressCityID;
                physicalAddressProvinceID = data.physicalAddressProvinceID;
                physicalAddressCountryID = data.physicalAddressCountryID;
                physicalAddressCode = data.physicalAddressCode;
                postalAddressStreetName = data.postalAddressStreetName;
                postalAddressStreetNumber = data.postalAddressStreetNumber;
                postalAddressSuburbID = data.postalAddressSuburbID;
                postalAddressCityID = data.postalAddressCityID;
                postalAddressProvinceID = data.postalAddressProvinceID;
                postalAddressCountryID = data.postalAddressCountryID;
                postalAddressCode = data.postalAddressCode;
                bModified = false;
            }
        }

        public PersonEntity(int inID, int inUserID, DateTime inModifiedDate, int inDeleted, string inFirstName, string inSecondName, string inSurname, string inIDNumber, int inGenderID, int inLanguageID, string inNationalityID, int inMaritalStatusID, string inCellNumber, string inTelNumber, string inEmailAddress, string inFax, string inWorkTelNumber, string inEmployerCompany, string inPhysicalAddressStreetName, string inPhysicalAddressStreetNumber, string inPhysicalAddressSuburbID, string inPhysicalAddressCityID, string inPhysicalAddressProvinceID, string inPhysicalAddressCountryID, string inPhysicalAddressCode, string inPostalAddressStreetName, string inPostalAddressStreetNumber, string inPostalAddressSuburbID, string inPostalAddressCityID, string inPostalAddressProvinceID, string inPostalAddressCountryID, string inPostalAddressCode)
        {
            iD = inID;
            userID = inUserID;
            modifiedDate = inModifiedDate;
            deleted = inDeleted;
            firstName = inFirstName;
            secondName = inSecondName;
            surname = inSurname;
            iDNumber = inIDNumber;
            genderID = inGenderID;
            languageID = inLanguageID;
            nationalityID = inNationalityID;
            maritalStatusID = inMaritalStatusID;
            cellNumber = inCellNumber;
            telNumber = inTelNumber;
            emailAddress = inEmailAddress;
            fax = inFax;
            workTelNumber = inWorkTelNumber;
            employerCompany = inEmployerCompany;
            physicalAddressStreetName = inPhysicalAddressStreetName;
            physicalAddressStreetNumber = inPhysicalAddressStreetNumber;
            physicalAddressSuburbID = inPhysicalAddressSuburbID;
            physicalAddressCityID = inPhysicalAddressCityID;
            physicalAddressProvinceID = inPhysicalAddressProvinceID;
            physicalAddressCountryID = inPhysicalAddressCountryID;
            physicalAddressCode = inPhysicalAddressCode;
            postalAddressStreetName = inPostalAddressStreetName;
            postalAddressStreetNumber = inPostalAddressStreetNumber;
            postalAddressSuburbID = inPostalAddressSuburbID;
            postalAddressCityID = inPostalAddressCityID;
            postalAddressProvinceID = inPostalAddressProvinceID;
            postalAddressCountryID = inPostalAddressCountryID;
            postalAddressCode = inPostalAddressCode;
            bModified = false;
        }

        #endregion

        #region Fields

        int iD = 0;
        int userID = 0;
        DateTime modifiedDate = DateTime.Now;
        int deleted = 0;
        string firstName = "";
        string secondName = "";
        string surname = "";
        string iDNumber = "";
        int genderID = 0;
        int languageID = 0;
        string nationalityID = "";
        int maritalStatusID = 0;
        string cellNumber = "";
        string telNumber = "";
        string emailAddress = "";
        string fax = "";
        string workTelNumber = "";
        string employerCompany = "";
        string physicalAddressStreetName = "";
        string physicalAddressStreetNumber = "";
        string physicalAddressSuburbID = "";
        string physicalAddressCityID = "";
        string physicalAddressProvinceID = "";
        string physicalAddressCountryID = "";
        string physicalAddressCode = "";
        string postalAddressStreetName = "";
        string postalAddressStreetNumber = "";
        string postalAddressSuburbID = "";
        string postalAddressCityID = "";
        string postalAddressProvinceID = "";
        string postalAddressCountryID = "";
        string postalAddressCode = "";
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
                if (iD != value)
                {
                    iD = value;
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
                if (userID != value)
                {
                    userID = value;
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
                if (modifiedDate != value)
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
                if (deleted != value)
                {
                    deleted = value;
                    bModified = true;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    bModified = true;
                }
            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (secondName != value)
                {
                    secondName = value;
                    bModified = true;
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    bModified = true;
                }
            }
        }

        public string IDNumber
        {
            get
            {
                return iDNumber;
            }
            set
            {
                if (iDNumber != value)
                {
                    iDNumber = value;
                    bModified = true;
                }
            }
        }

        public int GenderID
        {
            get
            {
                return genderID;
            }
            set
            {
                if (genderID != value)
                {
                    genderID = value;
                    bModified = true;
                }
            }
        }

        public int LanguageID
        {
            get
            {
                return languageID;
            }
            set
            {
                if (languageID != value)
                {
                    languageID = value;
                    bModified = true;
                }
            }
        }

        public string NationalityID
        {
            get
            {
                return nationalityID;
            }
            set
            {
                if (nationalityID != value)
                {
                    nationalityID = value;
                    bModified = true;
                }
            }
        }

        public int MaritalStatusID
        {
            get
            {
                return maritalStatusID;
            }
            set
            {
                if (maritalStatusID != value)
                {
                    maritalStatusID = value;
                    bModified = true;
                }
            }
        }

        public string CellNumber
        {
            get
            {
                return cellNumber;
            }
            set
            {
                if (cellNumber != value)
                {
                    cellNumber = value;
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
                if (telNumber != value)
                {
                    telNumber = value;
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
                if (emailAddress != value)
                {
                    emailAddress = value;
                    bModified = true;
                }
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                if (fax != value)
                {
                    fax = value;
                    bModified = true;
                }
            }
        }

        public string WorkTelNumber
        {
            get
            {
                return workTelNumber;
            }
            set
            {
                if (workTelNumber != value)
                {
                    workTelNumber = value;
                    bModified = true;
                }
            }
        }

        public string EmployerCompany
        {
            get
            {
                return employerCompany;
            }
            set
            {
                if (employerCompany != value)
                {
                    employerCompany = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressStreetName
        {
            get
            {
                return physicalAddressStreetName;
            }
            set
            {
                if (physicalAddressStreetName != value)
                {
                    physicalAddressStreetName = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressStreetNumber
        {
            get
            {
                return physicalAddressStreetNumber;
            }
            set
            {
                if (physicalAddressStreetNumber != value)
                {
                    physicalAddressStreetNumber = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressSuburbID
        {
            get
            {
                return physicalAddressSuburbID;
            }
            set
            {
                if (physicalAddressSuburbID != value)
                {
                    physicalAddressSuburbID = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressCityID
        {
            get
            {
                return physicalAddressCityID;
            }
            set
            {
                if (physicalAddressCityID != value)
                {
                    physicalAddressCityID = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressProvinceID
        {
            get
            {
                return physicalAddressProvinceID;
            }
            set
            {
                if (physicalAddressProvinceID != value)
                {
                    physicalAddressProvinceID = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressCountryID
        {
            get
            {
                return physicalAddressCountryID;
            }
            set
            {
                if (physicalAddressCountryID != value)
                {
                    physicalAddressCountryID = value;
                    bModified = true;
                }
            }
        }

        public string PhysicalAddressCode
        {
            get
            {
                return physicalAddressCode;
            }
            set
            {
                if (physicalAddressCode != value)
                {
                    physicalAddressCode = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressStreetName
        {
            get
            {
                return postalAddressStreetName;
            }
            set
            {
                if (postalAddressStreetName != value)
                {
                    postalAddressStreetName = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressStreetNumber
        {
            get
            {
                return postalAddressStreetNumber;
            }
            set
            {
                if (postalAddressStreetNumber != value)
                {
                    postalAddressStreetNumber = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressSuburbID
        {
            get
            {
                return postalAddressSuburbID;
            }
            set
            {
                if (postalAddressSuburbID != value)
                {
                    postalAddressSuburbID = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressCityID
        {
            get
            {
                return postalAddressCityID;
            }
            set
            {
                if (postalAddressCityID != value)
                {
                    postalAddressCityID = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressProvinceID
        {
            get
            {
                return postalAddressProvinceID;
            }
            set
            {
                if (postalAddressProvinceID != value)
                {
                    postalAddressProvinceID = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressCountryID
        {
            get
            {
                return postalAddressCountryID;
            }
            set
            {
                if (postalAddressCountryID != value)
                {
                    postalAddressCountryID = value;
                    bModified = true;
                }
            }
        }

        public string PostalAddressCode
        {
            get
            {
                return postalAddressCode;
            }
            set
            {
                if (postalAddressCode != value)
                {
                    postalAddressCode = value;
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
            return new PersonEntity(this);
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
						UserID, 
						ModifiedDate, 
						Deleted, 
						FirstName, 
						SecondName, 
						Surname, 
						IDNumber, 
						GenderID, 
						LanguageID, 
						NationalityID, 
						MaritalStatusID, 
						CellNumber, 
						TelNumber, 
						EmailAddress, 
						Fax, 
						WorkTelNumber, 
						EmployerCompany, 
						PhysicalAddressStreetName, 
						PhysicalAddressStreetNumber, 
						PhysicalAddressSuburbID, 
						PhysicalAddressCityID, 
						PhysicalAddressProvinceID, 
						PhysicalAddressCountryID, 
						PhysicalAddressCode, 
						PostalAddressStreetName, 
						PostalAddressStreetNumber, 
						PostalAddressSuburbID, 
						PostalAddressCityID, 
						PostalAddressProvinceID, 
						PostalAddressCountryID, 
						PostalAddressCode
					FROM Person
					WHERE iD = " + inID.ToString()))
                {
                    while (reader.Read())
                    {
                        iD = Convert.ToInt32(reader["ID"]);
                        userID = Convert.ToInt32(reader["UserID"]);
                        modifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                        deleted = Convert.ToInt32(reader["Deleted"]);
                        firstName = Convert.ToString(reader["FirstName"]);
                        secondName = Convert.ToString(reader["SecondName"]);
                        surname = Convert.ToString(reader["Surname"]);
                        iDNumber = Convert.ToString(reader["IDNumber"]);
                        genderID = Convert.ToInt32(reader["GenderID"]);
                        languageID = Convert.ToInt32(reader["LanguageID"]);
                        nationalityID = Convert.ToString(reader["NationalityID"]);
                        maritalStatusID = Convert.ToInt32(reader["MaritalStatusID"]);
                        cellNumber = Convert.ToString(reader["CellNumber"]);
                        telNumber = Convert.ToString(reader["TelNumber"]);
                        emailAddress = Convert.ToString(reader["EmailAddress"]);
                        fax = Convert.ToString(reader["Fax"]);
                        workTelNumber = Convert.ToString(reader["WorkTelNumber"]);
                        employerCompany = Convert.ToString(reader["EmployerCompany"]);
                        physicalAddressStreetName = Convert.ToString(reader["PhysicalAddressStreetName"]);
                        physicalAddressStreetNumber = Convert.ToString(reader["PhysicalAddressStreetNumber"]);
                        physicalAddressSuburbID = Convert.ToString(reader["PhysicalAddressSuburbID"]);
                        physicalAddressCityID = Convert.ToString(reader["PhysicalAddressCityID"]);
                        physicalAddressProvinceID = Convert.ToString(reader["PhysicalAddressProvinceID"]);
                        physicalAddressCountryID = Convert.ToString(reader["PhysicalAddressCountryID"]);
                        physicalAddressCode = Convert.ToString(reader["PhysicalAddressCode"]);
                        postalAddressStreetName = Convert.ToString(reader["PostalAddressStreetName"]);
                        postalAddressStreetNumber = Convert.ToString(reader["PostalAddressStreetNumber"]);
                        postalAddressSuburbID = Convert.ToString(reader["PostalAddressSuburbID"]);
                        postalAddressCityID = Convert.ToString(reader["PostalAddressCityID"]);
                        postalAddressProvinceID = Convert.ToString(reader["PostalAddressProvinceID"]);
                        postalAddressCountryID = Convert.ToString(reader["PostalAddressCountryID"]);
                        postalAddressCode = Convert.ToString(reader["PostalAddressCode"]);
                    }
                    bModified = false;
                    return true;
                }
            }
            catch (Exception ex)
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
                Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Create_Person");                
               
                proc.AddInputParameterWithValue("inUserID", userID);               
                proc.AddInputParameterWithValue("inDeleted", deleted);
                proc.AddInputParameterWithValue("inFirstName", firstName);
                proc.AddInputParameterWithValue("inSecondName", secondName);
                proc.AddInputParameterWithValue("inSurname", surname);
                proc.AddInputParameterWithValue("inIDNumber", iDNumber);
                proc.AddInputParameterWithValue("inGenderID", genderID);
                proc.AddInputParameterWithValue("inLanguageID", languageID);
                proc.AddInputParameterWithValue("inNationalityID", nationalityID);
                proc.AddInputParameterWithValue("inMaritalStatusID", maritalStatusID);
                proc.AddInputParameterWithValue("inCellNumber", cellNumber);
                proc.AddInputParameterWithValue("inTelNumber", telNumber);
                proc.AddInputParameterWithValue("inEmailAddress", emailAddress);
                proc.AddInputParameterWithValue("inFax", fax);
                proc.AddInputParameterWithValue("inWorkTelNumber", workTelNumber);
                proc.AddInputParameterWithValue("inEmployerCompany", employerCompany);
                proc.AddInputParameterWithValue("inPhysicalAddressStreetName", physicalAddressStreetName);
                proc.AddInputParameterWithValue("inPhysicalAddressStreetNumber", physicalAddressStreetNumber);
                proc.AddInputParameterWithValue("inPhysicalAddressSuburbID", physicalAddressSuburbID);
                proc.AddInputParameterWithValue("inPhysicalAddressCityID", physicalAddressCityID);
                proc.AddInputParameterWithValue("inPhysicalAddressProvinceID", physicalAddressProvinceID);
                proc.AddInputParameterWithValue("inPhysicalAddressCountryID", physicalAddressCountryID);
                proc.AddInputParameterWithValue("inPhysicalAddressCode", physicalAddressCode);
                proc.AddInputParameterWithValue("inPostalAddressStreetName", postalAddressStreetName);
                proc.AddInputParameterWithValue("inPostalAddressStreetNumber", postalAddressStreetNumber);
                proc.AddInputParameterWithValue("inPostalAddressSuburbID", postalAddressSuburbID);
                proc.AddInputParameterWithValue("inPostalAddressCityID", postalAddressCityID);
                proc.AddInputParameterWithValue("inPostalAddressProvinceID", postalAddressProvinceID);
                proc.AddInputParameterWithValue("inPostalAddressCountryID", postalAddressCountryID);
                proc.AddInputParameterWithValue("inPostalAddressCode", postalAddressCode);
                proc.AddOutParameter("outID", MySql.Data.MySqlClient.MySqlDbType.Int32);

                if (proc.Execute())
                {
                    iD = Convert.ToInt32(proc.GetParameterValue("outID"));
                    bModified = false;
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception ex)
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
                Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Update_Person");

                proc.AddInputParameterWithValue("inID", iD);
                proc.AddInputParameterWithValue("inUserID", userID);               
                proc.AddInputParameterWithValue("inDeleted", deleted);
                proc.AddInputParameterWithValue("inFirstName", firstName);
                proc.AddInputParameterWithValue("inSecondName", secondName);
                proc.AddInputParameterWithValue("inSurname", surname);
                proc.AddInputParameterWithValue("inIDNumber", iDNumber);
                proc.AddInputParameterWithValue("inGenderID", genderID);
                proc.AddInputParameterWithValue("inLanguageID", languageID);
                proc.AddInputParameterWithValue("inNationalityID", nationalityID);
                proc.AddInputParameterWithValue("inMaritalStatusID", maritalStatusID);
                proc.AddInputParameterWithValue("inCellNumber", cellNumber);
                proc.AddInputParameterWithValue("inTelNumber", telNumber);
                proc.AddInputParameterWithValue("inEmailAddress", emailAddress);
                proc.AddInputParameterWithValue("inFax", fax);
                proc.AddInputParameterWithValue("inWorkTelNumber", workTelNumber);
                proc.AddInputParameterWithValue("inEmployerCompany", employerCompany);
                proc.AddInputParameterWithValue("inPhysicalAddressStreetName", physicalAddressStreetName);
                proc.AddInputParameterWithValue("inPhysicalAddressStreetNumber", physicalAddressStreetNumber);
                proc.AddInputParameterWithValue("inPhysicalAddressSuburbID", physicalAddressSuburbID);
                proc.AddInputParameterWithValue("inPhysicalAddressCityID", physicalAddressCityID);
                proc.AddInputParameterWithValue("inPhysicalAddressProvinceID", physicalAddressProvinceID);
                proc.AddInputParameterWithValue("inPhysicalAddressCountryID", physicalAddressCountryID);
                proc.AddInputParameterWithValue("inPhysicalAddressCode", physicalAddressCode);
                proc.AddInputParameterWithValue("inPostalAddressStreetName", postalAddressStreetName);
                proc.AddInputParameterWithValue("inPostalAddressStreetNumber", postalAddressStreetNumber);
                proc.AddInputParameterWithValue("inPostalAddressSuburbID", postalAddressSuburbID);
                proc.AddInputParameterWithValue("inPostalAddressCityID", postalAddressCityID);
                proc.AddInputParameterWithValue("inPostalAddressProvinceID", postalAddressProvinceID);
                proc.AddInputParameterWithValue("inPostalAddressCountryID", postalAddressCountryID);
                proc.AddInputParameterWithValue("inPostalAddressCode", postalAddressCode);

                if (proc.Execute())
                {
                    bModified = false;
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception ex)
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
                if (iD == -1)
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
