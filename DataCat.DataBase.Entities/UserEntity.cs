using System;
using System.Collections;
using DataCat.Connection;
using MySql.Data.MySqlClient;
using DataCat.Utilities;
using System.Drawing;
namespace DataCat.Database.Entities
{
    public class UserEntity
    {
        #region Constructors

        public UserEntity()
            : this(-1)
        {
        }

        public UserEntity(int inID)
        {
            if (inID != -1)
            {
                Load(inID);
                bModified = false;
            }
            else
                iD = -1;
        }

        public UserEntity(object rawdata)
        {
            if (rawdata is UserEntity)
            {
                UserEntity data = rawdata as UserEntity;

                iD = data.iD;
                created = data.created;
                modified = data.modified;
                deleted = data.deleted;
                userName = data.userName;
                password = data.password;
                type = data.type;
                personID = data.personID;
                imageID = data.imageID;
                bModified = false;
            }
        }

        public UserEntity(int inID, string inCreated, string inModified, int inDeleted, string inUserName, string inPassword, int inType, int inPersonID, int inImageID)
        {
            iD = inID;
            created = inCreated;
            modified = inModified;
            deleted = inDeleted;
            userName = inUserName;
            password = inPassword;
            type = inType;
            personID = inPersonID;
            imageID = inImageID;
            bModified = false;
        }

        #endregion

        #region Fields

        int iD = 0;
        string created = "";
        string modified = "";
        int deleted = 0;
        string userName = "";
        string password = "";
        int type = 0;
        int personID = 0;
        int imageID = 0;
        bool bModified = false;

        #endregion

        #region Properties


        public Image ThumbNail { get; set; }
        public Image ProfileImage { get; set; }

        public bool Modified
        {
            get
            {
                return bModified;
            }
        }
     
        public bool LoadThumbNail()
        {
            try
            {
                ThumbNail = Connection.Connection.GetThumbNail(imageID);
                return true;
            }
            catch (Exception)
            {
                ThumbNail = new Bitmap(100, 100);
                return false;
            }
        }

        public bool LoadProfileImage()
        {
            try
            {
                ProfileImage = Connection.Connection.GetImage(imageID);
                return true;
            }
            catch (Exception)
            {
                ProfileImage = new Bitmap(100,100);
                return false;
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

        public string Created
        {
            get
            {
                return created;
            }
            set
            {
                if (created != value)
                {
                    created = value;
                    bModified = true;
                }
            }
        }

        public string ModifiedDate
        {
            get
            {
                return modified;
            }
            set
            {
                if (modified != value)
                {
                    modified = value;
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

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    bModified = true;
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                    bModified = true;
                }
            }
        }

        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                if (type != value)
                {
                    type = value;
                    bModified = true;
                }
            }
        }

        public int PersonID
        {
            get
            {
                return personID;
            }
            set
            {
                if (personID != value)
                {
                    personID = value;
                    bModified = true;
                }
            }
        }

        public int ImageID
        {
            get
            {
                return imageID;
            }
            set
            {
                if (imageID != value)
                {
                    imageID = value;
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
            return new UserEntity(this);
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
						Created, 
						Modified, 
						Deleted, 
						UserName, 
						Password, 
						Type, 
						PersonID, 
						ImageID
					FROM User
					WHERE iD = " + inID.ToString()))
                {
                    while (reader.Read())
                    {
                        iD = Convert.ToInt32(reader["ID"]);
                        created = Convert.ToString(reader["Created"]);
                        modified = Convert.ToString(reader["Modified"]);
                        deleted = Convert.ToInt32(reader["Deleted"]);
                        userName = Convert.ToString(reader["UserName"]);
                        password = Convert.ToString(reader["Password"]);
                        type = Convert.ToInt32(reader["Type"]);
                        personID = Convert.ToInt32(reader["PersonID"]);
                        imageID = Convert.ToInt32(reader["ImageID"]);
                    }
                }
              
                bModified = false;
                return true;
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
                Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Create_User");
                
                proc.AddInputParameterWithValue("inID", iD);
                proc.AddInputParameterWithValue("inCreated", created);
                proc.AddInputParameterWithValue("inModified", modified);
                proc.AddInputParameterWithValue("inDeleted", deleted);
                proc.AddInputParameterWithValue("inUserName", userName);
                proc.AddInputParameterWithValue("inPassword", password);
                proc.AddInputParameterWithValue("inType", type);
                proc.AddInputParameterWithValue("inPersonID", personID);
                proc.AddInputParameterWithValue("inImageID", imageID);
                proc.AddOutParameter("outID",MySqlDbType.Int32);

                try
                {
                    proc.Execute();                
                    iD = Convert.ToInt32(proc.GetParameterValue("outID"));
                    bModified = false;
                    return true;
                }
                catch
                {
                    return false;
                }     
                    
                
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
                Connection.StoredProcedure proc = Connection.Connection.CreateStoredProcedure("Update_User");
                
                proc.AddInputParameterWithValue("inID", iD);
                proc.AddInputParameterWithValue("inCreated", created);
                proc.AddInputParameterWithValue("inModified", modified);
                proc.AddInputParameterWithValue("inDeleted", deleted);
                proc.AddInputParameterWithValue("inUserName", userName);
                proc.AddInputParameterWithValue("inPassword", password);
                proc.AddInputParameterWithValue("inType", type);
                proc.AddInputParameterWithValue("inPersonID", personID);
                proc.AddInputParameterWithValue("inImageID", imageID);

                proc.Execute();                   

                bModified = false;
                return true;                               
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