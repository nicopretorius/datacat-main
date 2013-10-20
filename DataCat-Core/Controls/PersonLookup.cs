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
    public partial class PersonLookup : UserControl
    {
        public event PersonSelectedHandler PersonSelected;
        public PersonLookup()
        {
            InitializeComponent();
        }
        public PersonEntity CurrentSelectedPerson = new PersonEntity();

        public override void ResetText()
        {
            base.ResetText();
            txtSearch.Text = "";
            lblSelected.Text = "";

        }

        public void SetPerson(PersonEntity person)
        {
            CurrentSelectedPerson = person;
            txtSearch.Text = person.FirstName + " " + person.Surname;
            lblSelected.Text = person.FirstName + " " + person.Surname;
        }

        private void LookupDialogOnPersonSelected(PersonEntity selectedEntity)
        {
            txtSearch.Text = selectedEntity.FirstName + " " + selectedEntity.Surname;
            lblSelected.Text = selectedEntity.FirstName + " " + selectedEntity.Surname;


            if (PersonSelected != null) PersonSelected  (selectedEntity);
        }

        public void Clear()
        {
            txtSearch.Text = "";
            lblSelected.Text = "";
        }

        public void GrabFocus()
        {
            txtSearch.Focus();

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dlgPersonLookup lookupDialog = new dlgPersonLookup(txtSearch.Text);
                lookupDialog.PersonSelected += LookupDialogOnPersonSelected;
                lookupDialog.ShowDialog();
            }
        }

     

    }
}
