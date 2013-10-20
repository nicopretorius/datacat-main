using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;
using DataCat.Utilities;
namespace DataCat.Connection
{
    public class StoredProcedure
    {
        string commandText;

        public string CommandText
        {
            get { return commandText; }
            set { commandText = value; }
        }
        MySqlConnection con;
        MySqlCommand cmd;

        public StoredProcedure(string connectionString, string ProcName)
        {
            try
            {
                con = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(ProcName, con);
                cmd.CommandText = ProcName;
                cmd.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        private MySqlParameterCollection parameters;

        public MySqlParameterCollection Parameters
        {
            get { return parameters; }
            set
            {
                parameters = value;

            }
        }

        public object GetParameterValue(string Name)
        {
            return cmd.Parameters[Name].Value;
        }

        public void AddInputParameterWithValue(string name, object Value)
        {
            if (Value is string)
            {
                Value = Connection.GetSafeString(Value as string);
            }

            cmd.Parameters.AddWithValue(name, Value);

        }

        public void AddOutParameter(string name, MySqlDbType type)
        {
            cmd.Parameters.Add(name, type);
            cmd.Parameters[name].Direction = ParameterDirection.Output;

        }

        public bool Execute()
        {
            bool returnValue = false;
            try
            {
                con.Open();
                Console.WriteLine(commandText);
                foreach (MySqlParameter parameter in cmd.Parameters)
                {
                    Console.WriteLine(parameter.ParameterName + " " + Convert.ToString(parameter.Value));
                }
                cmd.ExecuteNonQuery();
                returnValue = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                returnValue = false;
            }
            finally
            {
                con.Close();
            }
            return returnValue;
        }
       
    }

    public class Connection
    {
        public static string GetSafeString(string oldSql)
        {
            string strValue = oldSql;
            strValue = strValue.Replace("'", "''");
            strValue = strValue.Replace("--", "");
            strValue = strValue.Replace("[", "[[]");
            strValue = strValue.Replace("%", "[%]");

            return strValue;
        }

       

        private static string conString = "";

        public static void SetConnectionString(string ConnectionString)
        {
            conString = ConnectionString;
        }

        

        public static StoredProcedure CreateStoredProcedure(string ProcedureName)
        {
            StoredProcedure proc = new StoredProcedure(conString, ProcedureName);
            return proc;
        }



        public static MySqlDataReader ExecureReader(string SQL)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                Console.WriteLine(SQL);
                con.Open();
                var com = new MySqlCommand(SQL, con);
                MySqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {

            }
        }




        public static int SaveImage(System.Drawing.Image img)
        {
            int ret = -1;
            WebCam.SaveImageCapture("test.png", img);
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                img = Utilities.Utilities.ResizeImage(img, new System.Drawing.Size(1024, 768));
                con.Open();
                MemoryStream fs = new MemoryStream();
                MemoryStream ts = new MemoryStream();

                System.Drawing.Image thumb = Utilities.Utilities.ResizeImage(img, new Size(128, 128));

                thumb.Save(ts,System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
               
                               
                byte[] imgData = fs.GetBuffer();
                byte[] thumbData = ts.GetBuffer();

                MySqlCommand mCmd = new MySqlCommand("INSERT INTO Image(Image,ThumbNail) VALUES(@img_data,@thumb_data); SELECT LAST_INSERT_ID();", con);
                mCmd.Parameters.AddWithValue("@img_data", imgData);
                mCmd.Parameters.AddWithValue("@thumb_data", thumbData);

               
                ret = Convert.ToInt32(mCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return ret;

        }

        public static int UpdateImage(System.Drawing.Image img, int ImageID)
        {
            int ret = -1;
            //  WebCam.SaveImageCapture("test.png", img);
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                img = Utilities.Utilities.ResizeImage(img, new System.Drawing.Size(1024, 768));
                con.Open();
                MemoryStream fs = new MemoryStream();
                MemoryStream ts = new MemoryStream();

                System.Drawing.Image thumb = Utilities.Utilities.ResizeImage(img, new Size(128, 128));

                thumb.Save(ts, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);


                byte[] imgData = fs.GetBuffer();
                byte[] thumbData = ts.GetBuffer();
                MySqlCommand mCmd = new MySqlCommand("UPDATE Image SET Image =@img_data,ThumbNail=@thum_data WHERE ID = " + ImageID.ToString(), con);
                mCmd.Parameters.AddWithValue("@img_data", imgData);
                mCmd.Parameters.AddWithValue("@thum_data", thumbData);
                ret = Convert.ToInt32(mCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return ret;

        }

        public static System.Drawing.Image GetImage(string SQL)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                con.Open();
                MemoryStream MemStream = null;
                object o = com.ExecuteScalar();
                byte[] ImageByte = (byte[])o;
                MemStream = new MemoryStream(ImageByte);
                return System.Drawing.Image.FromStream(MemStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public static System.Drawing.Image GetLandParcelImage(int ImageID)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                string SQL = "SELECT Image FROM LandParcelImage WHERE ID = " + ImageID.ToString();
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                con.Open();
                MemoryStream MemStream = null;
                object o = com.ExecuteScalar();
                byte[] ImageByte = (byte[])o;
                MemStream = new MemoryStream(ImageByte);
                return System.Drawing.Image.FromStream(MemStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public static System.Drawing.Image GetThumbNail(int ImageID)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                string SQL = "SELECT ThumbNail FROM Image WHERE ID = " + ImageID.ToString();
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                con.Open();
                MemoryStream MemStream = null;
                object o = com.ExecuteScalar();
                byte[] ImageByte = (byte[])o;
                MemStream = new MemoryStream(ImageByte);
                return System.Drawing.Image.FromStream(MemStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public static System.Drawing.Image GetImage(int ImageID)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                string SQL = "SELECT Image FROM Image WHERE ID = " + ImageID.ToString();
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                con.Open();
                MemoryStream MemStream = null;
                object o = com.ExecuteScalar();
                byte[] ImageByte = (byte[])o;
                MemStream = new MemoryStream(ImageByte);
                return System.Drawing.Image.FromStream(MemStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        private static void ExecuteNonQuery(String SQL)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                con.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        public static object ExecuteScalar(string SQL)
        {
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                MySqlCommand com = new MySqlCommand(SQL, con);
                com.CommandType = CommandType.Text;
                object data = "-1";
                con.Open();

                data = com.ExecuteScalar();
                con.Close();
                Console.WriteLine(SQL);

                return data;

            }
            finally
            {
                con.Close();
            }
        }
    }
}
