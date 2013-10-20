using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataCat.Database.Entities;

namespace DataCat.Controls
{
    public delegate void UserSelected(UserEntity selectedUser);
    public partial class UserLookup : UserControl
    {
        public event UserSelectedHandler UserSelected;
        public UserLookup()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               dlgUserLookup lookupDialog = new dlgUserLookup(txtSearch.Text);
               lookupDialog.UserSelected += LookupDialogOnUserSelected;
               lookupDialog.ShowDialog();
            }
        }

        private void LookupDialogOnUserSelected(UserEntity selectedUser)
        {
            txtSearch.Text =  selectedUser.UserName.ToString();
            lblSelectedUser.Text = selectedUser.UserName;

            if (UserSelected != null) UserSelected(selectedUser);

        }

        public void Clear()
        {
            txtSearch.Text = "";
            lblSelectedUser.Text = "";
        }

        public void GrabFocus()
        {
            txtSearch.Focus();
      
        }

        private void UserLookup_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void UserLookup_Enter(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }
    }
}
