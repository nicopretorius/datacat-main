using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using DataCat.Connection;
using DataCat.Database.Entities;
using DataCat.Utilities;

namespace DataCat.Controls
{
    public delegate void ProjectSelectedHandler(Database.Entities.ProjectEntity projectEntity);
    public partial class dlgProjectLookup : Form
    {
        public event ProjectSelectedHandler ProjectSelected;
        public dlgProjectLookup()
        {
            InitializeComponent();
        }

        public dlgProjectLookup(string Search)
        {
            InitializeComponent();
            LoadProjects(Search);

            txtSearch.Text = Search;
            txtSearch.Focus();
        }

        private void ActivateSelection()
        {
            int projectID = Convert.ToInt32(lsProjects.SelectedItems[0].Name);
            ProjectEntity c = new ProjectEntity(projectID);
            if (ProjectSelected != null)
            {
                ProjectSelected(c);
            }
            this.Close();
        }

        private void LoadProjects(string search)
        {
            lsProjects.Clear();
            lsProjects.Columns.Add("Logo", 200);
            lsProjects.Columns.Add("Company Name", 200);
            lsProjects.Columns.Add("Project Description", 100);
            lsProjects.Columns.Add("Contact Person", 500);
            lsProjects.FullRowSelect = true;
            lsProjects.HScrollBarDisplayMode = BetterListViewScrollBarDisplayMode.Hide;
            lsProjects.GridLines = BetterListViewGridLines.Horizontal;
            lsProjects.View = BetterListViewView.Details;
            lsProjects.Columns[1].AutoResize(BetterListViewColumnHeaderAutoResizeStyle.HeaderSize);

            lsProjects.MultiSelect = false;
            try
            {
                using (MySql.Data.MySqlClient.MySqlDataReader reader = Connection.Connection.ExecureReader(@"SELECT 
                                Project.ID AS ProjectID,
                                Project.Description AS Description,
                                ref_ProjectType.Name AS ProjectType,
                                CompanyName,
                                ContactPersonTel,
                                ThumbNail
                            FROM
                                Project
                                    INNER JOIN
                                Client ON Client.ID = Project.ClientID
                                    LEFT JOIN
                                ref_ProjectType ON Project.ProjectTypeID = ref_ProjectType.ID
                                    LEFT JOIN
                                Image ON Client.LogoImageID = Image.ID WHERE CompanyName LIKE '%" + search + "%' OR Project.Description LIKE '%"+search+"%' OR ref_ProjectType.Name like '%"+search+"%';")
                    )
                {

                    while (reader.Read())
                    {
                        Image thumnail;

                        try
                        {
                            MemoryStream MemStream = null;
                            byte[] thumbByte = (byte[])reader["Thumbnail"];
                            MemStream = new MemoryStream(thumbByte);
                            thumnail = System.Drawing.Image.FromStream(MemStream);
                        }
                        catch (Exception)
                        {
                            thumnail = new Bitmap(100, 100);
                        }

                        thumnail = Utilities.Utilities.ResizeImage(thumnail, new Size(48, 36));
                        BetterListViewItem lstItem = new BetterListViewItem(new[] { reader["ProjectID"].ToString(),
                                                                            reader["Description"].ToString(),
                                                                             reader["ProjectType"].ToString(),
                                                                              reader["CompanyName"].ToString(),
                                                                               reader["ContactPersonTel"].ToString()
                        
                        });
                        lstItem.Name = reader["ProjectID"].ToString();
                        lstItem.Image = thumnail;

                        lsProjects.Items.Add(lstItem);

                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }


        }

      



        private void btnUse_Click_1(object sender, EventArgs e)
        {
            if (lsProjects.Items.Count == 1)
            {
                ActivateSelection();

            }


            if (lsProjects.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lsProjects_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && lsProjects.SelectedItems.Count > 0)
            {
                ActivateSelection();

            }
        }

        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadProjects(txtSearch.Text);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && lsProjects.Items.Count > 0)
            {
                lsProjects.Focus();
                lsProjects.Items[0].Selected = true;
            }
        }

        private void lsProjects_DoubleClick(object sender, EventArgs e)
        {

            if (lsProjects.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void lsProjects_DrawItemBackground(object sender, BetterListViewDrawItemBackgroundEventArgs eventArgs)
        {

            if (eventArgs.Item.Index % 2 == 0)
            {
                Brush brushSelection = new SolidBrush(Color.FromArgb(220, 240, 255));
                eventArgs.Graphics.FillRectangle(brushSelection, eventArgs.ItemBounds.BoundsSelection);
                brushSelection.Dispose();
            }
        }


    }
}
