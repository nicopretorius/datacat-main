using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataCat.Plugins;
using DataCat.Database.Entities;
namespace DPL_0004
{
    public partial class ProjectMaintenance : UserControl,IPlugin
    {
        enum EEditState
        {
            Cancel,
            New,
            Edit
        }
        EEditState currentState;

        public ProjectMaintenance()
        {
            InitializeComponent();
            
        }

        ProjectEntity curProject = new ProjectEntity();

        public void Initialize()
        {
            ChangeEditState(EEditState.Cancel);
            cmbProject.DataSource = DataCat.Controls.ListData.GetProjectTypes();
        }

        private void ClearControls()
        {
            clientLookup1.ResetText();
        
            txtDescription.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpDeadLine.Value = DateTime.Now;
        }

        private void ChangeEditState(EEditState newState)
        {
            if (newState == EEditState.Cancel)
            {
                ClearControls();
                grpSearch.Enabled = true;
                grpData.Enabled = false;
                projectLookup1.ResetText();
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                projectLookup1.ResetText();
                btnCancel.Enabled = false;
            } else
                if (newState == EEditState.Edit)
                {
                    ClearControls();
                    grpSearch.Enabled = false;
                    grpData.Enabled = true;
                    projectLookup1.ResetText();
                    btnSave.Enabled = true;
                    btnNew.Enabled = false;
                    btnCancel.Enabled = true;
                } else
                    if (newState == EEditState.New)
                    {
                        ClearControls();
                        grpSearch.Enabled = false;
                        grpData.Enabled = true;
                        projectLookup1.ResetText();
                        btnSave.Enabled = true;
                        btnNew.Enabled = false;
                        btnCancel.Enabled = true;
                    }
        }

        private void PopulateCurrentProject()
        {
            txtDescription.Text = curProject.Description;
          
            if (curProject.ClientID != -1)clientLookup1.SetClient(new ClientEntity(curProject.ClientID));
            dtpDeadLine.Value = curProject.DeadLine;
            dtpStartDate.Value = curProject.StartDate;
            dtpEndDate.Value = curProject.EndDate;
        }

        private void UpdateCurrentProject()
        {
            curProject.Description = txtDescription.Text;
            curProject.ClientID = clientLookup1.CurrentSelectedClient.ID;
            curProject.StartDate = dtpStartDate.Value;
            curProject.EndDate = dtpEndDate.Value;
            curProject.DeadLine = dtpDeadLine.Value;
        }

        private void projectLookup1_ProjectSelected(DataCat.Database.Entities.ProjectEntity projectEntity)
        {
            curProject = projectEntity;
            ChangeEditState(EEditState.Edit);
            PopulateCurrentProject();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCurrentProject();
            curProject.Save();
            ChangeEditState(EEditState.Cancel);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChangeEditState(EEditState.New);
            curProject = new ProjectEntity();
            ClearControls();
            clientLookup1.GrabFocus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeEditState(EEditState.Cancel);
        }
    }
}
