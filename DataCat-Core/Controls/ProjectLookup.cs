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

    public partial class ProjectLookup : UserControl
    {
        public event ProjectSelectedHandler ProjectSelected;
        public ProjectLookup()
        {
            InitializeComponent();
        }

        public ProjectEntity CurrentSelectedProject = new ProjectEntity();
        public void SetProject(ProjectEntity project)
        {
            CurrentSelectedProject = project;
            txtSearch.Text = project.Description;
            lblSelectedProject.Text = project.Description;
        }

        public override void ResetText()
        {
            base.ResetText();
            lblSelectedProject.Text = "";
            txtSearch.Text = "";
            
        }


        private void LookupDialogOnProjectSelected(ProjectEntity selectedEntity)
        {
            txtSearch.Text = selectedEntity.Description.ToString();
            lblSelectedProject.Text = selectedEntity.Description;


            if (ProjectSelected != null) ProjectSelected(selectedEntity);
        }

        public void Clear()
        {
            txtSearch.Text = "";
            lblSelectedProject.Text = "";
        }

        public void GrabFocus()
        {
            txtSearch.Focus();

        }

        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dlgProjectLookup lookupDialog = new dlgProjectLookup(txtSearch.Text);
                lookupDialog.ProjectSelected += LookupDialogOnProjectSelected;
                lookupDialog.ShowDialog();
            }
        }

    }
}
