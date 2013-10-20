using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataCat.Utilities;
using MySql.Data.MySqlClient;
using DataCat.Connection;

namespace DataCat.Database.Entities
{
   public class ProjectEntity
	{
		#region Constructors

		public ProjectEntity()
			: this(-1)
		{
		}

		public ProjectEntity(int inID)
		{
			if(inID != -1)
			{
					Load(inID);
					bModified = false;
			} else
					iD = -1;
		}

		public ProjectEntity(object rawdata)
		{
			if(rawdata is ProjectEntity)
			{
				ProjectEntity data = rawdata as ProjectEntity;

				iD = data.iD;
				clientID = data.clientID;
				startDate = data.startDate;
				endDate = data.endDate;
				deadLine = data.deadLine;
				completionID = data.completionID;
				countryID = data.countryID;
				provinceID = data.provinceID;
				cityID = data.cityID;
				suburbID = data.suburbID;
				address = data.address;
				projectTypeID = data.projectTypeID;
				description = data.description;
				bModified = false;
			}
		}

		public ProjectEntity(int inID, int inClientID, DateTime inStartDate, DateTime inEndDate, DateTime inDeadLine, int inCompletionID, int inCountryID, int inProvinceID, int inCityID, int inSuburbID, string inAddress, int inProjectTypeID, string inDescription)
		{
			iD = inID;
			clientID = inClientID;
			startDate = inStartDate;
			endDate = inEndDate;
			deadLine = inDeadLine;
			completionID = inCompletionID;
			countryID = inCountryID;
			provinceID = inProvinceID;
			cityID = inCityID;
			suburbID = inSuburbID;
			address = inAddress;
			projectTypeID = inProjectTypeID;
			description = inDescription;
			bModified = false;
		}

		#endregion

		#region Fields

		int iD = 0;
		int clientID = 0;
		DateTime startDate = DateTime.Now;
		DateTime endDate = DateTime.Now;
		DateTime deadLine = DateTime.Now;
		int completionID = 0;
		int countryID = 0;
		int provinceID = 0;
		int cityID = 0;
		int suburbID = 0;
		string address = "";
		int projectTypeID = 0;
		string description = "";
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

		public int ClientID
		{
			get
			{
				return clientID;
			}
			set
			{
				if(clientID != value)
				{
					clientID = value;
					bModified = true;
				}
			}
		}

		public DateTime StartDate
		{
			get
			{
				return startDate;
			}
			set
			{
				if(startDate != value)
				{
					startDate = value;
					bModified = true;
				}
			}
		}

		public DateTime EndDate
		{
			get
			{
				return endDate;
			}
			set
			{
				if(endDate != value)
				{
					endDate = value;
					bModified = true;
				}
			}
		}

		public DateTime DeadLine
		{
			get
			{
				return deadLine;
			}
			set
			{
				if(deadLine != value)
				{
					deadLine = value;
					bModified = true;
				}
			}
		}

		public int CompletionID
		{
			get
			{
				return completionID;
			}
			set
			{
				if(completionID != value)
				{
					completionID = value;
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

		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				if(address != value)
				{
					address = value;
					bModified = true;
				}
			}
		}

		public int ProjectTypeID
		{
			get
			{
				return projectTypeID;
			}
			set
			{
				if(projectTypeID != value)
				{
					projectTypeID = value;
					bModified = true;
				}
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set
			{
				if(description != value)
				{
					description = value;
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
			return new ProjectEntity(this);
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
						ClientID, 
						StartDate, 
						EndDate, 
						DeadLine, 
						CompletionID, 
						CountryID, 
						ProvinceID, 
						CityID, 
						SuburbID, 
						Address, 
						ProjectTypeID, 
						Description
					FROM Project
					WHERE iD = " + inID.ToString()))
                {
                    while (reader.Read())
                    {

                        iD = Convert.ToInt32(reader["ID"]);
                        clientID = Convert.ToInt32(reader["ClientID"]);
                        startDate = Convert.ToDateTime(reader["StartDate"]);
                        endDate = Convert.ToDateTime(reader["EndDate"]);
                        deadLine = Convert.ToDateTime(reader["DeadLine"]);
                        completionID = Convert.ToInt32(reader["CompletionID"]);
                        countryID = Convert.ToInt32(reader["CountryID"]);
                        provinceID = Convert.ToInt32(reader["ProvinceID"]);
                        cityID = Convert.ToInt32(reader["CityID"]);
                        suburbID = Convert.ToInt32(reader["SuburbID"]);
                        address = Convert.ToString(reader["Address"]);
                        projectTypeID = Convert.ToInt32(reader["ProjectTypeID"]);
                        description = Convert.ToString(reader["Description"]);
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
				Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Create_Project");
			    
				proc.AddInputParameterWithValue("inClientID", clientID); 
				proc.AddInputParameterWithValue("inStartDate", startDate); 
				proc.AddInputParameterWithValue("inEndDate", endDate); 
				proc.AddInputParameterWithValue("inDeadLine", deadLine); 
				proc.AddInputParameterWithValue("inCompletionID", completionID); 
				proc.AddInputParameterWithValue("inCountryID", countryID); 
				proc.AddInputParameterWithValue("inProvinceID", provinceID); 
				proc.AddInputParameterWithValue("inCityID", cityID); 
				proc.AddInputParameterWithValue("inSuburbID", suburbID); 
				proc.AddInputParameterWithValue("inAddress", address); 
				proc.AddInputParameterWithValue("inProjectTypeID", projectTypeID); 
				proc.AddInputParameterWithValue("inDescription", description);
				proc.AddOutParameter("outID",  MySql.Data.MySqlClient.MySqlDbType.Int32);

				if (proc.Execute())
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
				Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Update_Project");
                proc.AddInputParameterWithValue("inID", iD);
                proc.AddInputParameterWithValue("inClientID", clientID);
                proc.AddInputParameterWithValue("inStartDate", startDate);
                proc.AddInputParameterWithValue("inEndDate", endDate);
                proc.AddInputParameterWithValue("inDeadLine", deadLine);
                proc.AddInputParameterWithValue("inCompletionID", completionID);
                proc.AddInputParameterWithValue("inCountryID", countryID);
                proc.AddInputParameterWithValue("inProvinceID", provinceID);
                proc.AddInputParameterWithValue("inCityID", cityID);
                proc.AddInputParameterWithValue("inSuburbID", suburbID);
                proc.AddInputParameterWithValue("inAddress", address);
                proc.AddInputParameterWithValue("inProjectTypeID", projectTypeID);
                proc.AddInputParameterWithValue("inDescription", description);

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
