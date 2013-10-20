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
 
    public partial class ClientLookup : UserControl
    {
        public ClientEntity CurrentSelectedClient = new ClientEntity();



        public event ClientSelectedHandler ClientSelected;
        public ClientLookup()
        {
            InitializeComponent();
        }

        public void SetClient(ClientEntity ent)
        {
            txtSearch.Text = ent.CompanyName;
            lblLookup.Text = ent.CompanyName;
            CurrentSelectedClient = ent;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dlgClientLookup lookupDialog = new dlgClientLookup(txtSearch.Text);
                lookupDialog.ClientSelected += LookupDialogOnClientSelected;
                lookupDialog.ShowDialog();
            }
        }

        private void LookupDialogOnClientSelected(ClientEntity selectedClient)
        {
            txtSearch.Text =   selectedClient.CompanyName.ToString();
            lblSelectedUser.Text = selectedClient.CompanyName;
      

            if (ClientSelected != null) ClientSelected(selectedClient);
            CurrentSelectedClient = selectedClient;
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

        public override void ResetText()
        {
            base.ResetText();
            txtSearch.Text = "";
            lblSelectedUser.Text = "";
            CurrentSelectedClient = new ClientEntity();
        }

    }
}
