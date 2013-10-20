using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataCat.Connection;
using MySql.Data.MySqlClient;

namespace DataCat_Client
{
    public delegate void LoginSuccessHandler(string username);

    public partial class frmLogin : Form
    {
        int LoggedInUserID = -1;
        public event LoginSuccessHandler LoginSuccess;
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtHost.Text == "")
               DataCat.Connection.Connection.SetConnectionString("Server=127.0.0.1;Port=3306;Database=DataCat;Uid=DataCat;Pwd=geentoegang;");
            else
                DataCat.Connection.Connection.SetConnectionString("Server=" + txtHost.Text + " ;Port=3306;Database=DataCat;Uid=DataCat;Pwd=geentoegang;");

            if (txtUserName.Text == "")
            {
                MessageBox.Show("No User Name Supplied!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("No Password Supplied!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Enabled = false;
            LoggedInUserID = -1;

            try
            {
                LoggedInUserID = Convert.ToInt32(Connection.ExecuteScalar("SELECT ID FROM User WHERE Deleted = 0 AND UserName = " +
                          "'" + Connection.GetSafeString(txtUserName.Text.ToLower()) + "' AND Password = '" + Connection.GetSafeString(txtPassword.Text) + "';"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoggedInUserID = -1;
            }

            if (LoggedInUserID > 0)
            {
                Shared.userEntity = new DataCat.Database.Entities.UserEntity(LoggedInUserID);               
                Shared.Loginauthorized = true;
               
                if (LoginSuccess != null) LoginSuccess("niclaas");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUserName.Text = "";
                this.Enabled = true;
               
                
            }            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Shared.Loginauthorized = false;
            this.Dispose();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHost.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtHost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }     
    }
}
