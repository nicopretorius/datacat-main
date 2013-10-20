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
    public delegate void PersonSelectedHandler(Database.Entities.PersonEntity personEntity);
    public partial class dlgPersonLookup : Form
    {
        public event PersonSelectedHandler PersonSelected;
        public dlgPersonLookup()
        {
            InitializeComponent();
        }

        public dlgPersonLookup(string Search)
        {
            InitializeComponent();
            LoadPeople(Search);

            txtSearch.Text = Search;
            txtSearch.Focus();
        }

        private void ActivateSelection()
        {
            int projectID = Convert.ToInt32(lsData.SelectedItems[0].Name);
            PersonEntity c = new PersonEntity(projectID);
            if (PersonSelected != null)
            {
                PersonSelected(c);
            }
            this.Close();
        }

        private void LoadPeople(string search)
        {
            lsData.Clear();
            lsData.Columns.Add("Picture", 100);
            lsData.Columns.Add("IDNumber", 300);
            lsData.Columns.Add("Name", 200);
            lsData.Columns.Add("Surname", 100);
            lsData.Columns.Add("Roles", 200);
            lsData.FullRowSelect = true;
            lsData.HScrollBarDisplayMode = BetterListViewScrollBarDisplayMode.Hide;
            lsData.GridLines = BetterListViewGridLines.Horizontal;
            lsData.View = BetterListViewView.Details;

            lsData.MultiSelect = false;
            try
            {
                using (MySql.Data.MySqlClient.MySqlDataReader reader = Connection.Connection.ExecureReader(@"
                                SELECT Person.ID AS PersonID,
                                        IDNumber,
                                        FirstName,
                                        Surname,
                                        '' AS Roles,
                                        ThumbNail 
                                FROM Person LEFT JOIN Image ON Person.ProfileImageID = Image.ID WHERE Concat(FirstName,' ',Surname) like '%"+search+"%' OR FirstName LIKE '%" + search + "%' OR Surname LIKE '%" + search + "%' OR IDNumber like '%" + search + "%';")
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
                        BetterListViewItem lstItem = new BetterListViewItem(new[] { reader["PersonID"].ToString(),

                                                                            reader["IDNumber"].ToString(),
                                                                             reader["FirstName"].ToString(),
                                                                              reader["Surname"].ToString(),
                                                                               reader["Roles"].ToString()
                        
                        });
                        lstItem.Name = reader["PersonID"].ToString();
                        lstItem.Image = thumnail;

                        lsData.Items.Add(lstItem);

                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }


        }






     

       
       

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPeople(txtSearch.Text);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && lsData.Items.Count > 0)
            {
                lsData.Focus();
                lsData.Items[0].Selected = true;
            }
        }

        private void lsData_DoubleClick(object sender, EventArgs e)
        {

            if (lsData.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void lsData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lsData.SelectedItems.Count > 0)
            {
                ActivateSelection();

            }
        }

    

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (lsData.Items.Count == 1)
            {
                ActivateSelection();

            }


            if (lsData.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsData_DrawItemBackground(object sender, BetterListViewDrawItemBackgroundEventArgs eventArgs)
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
