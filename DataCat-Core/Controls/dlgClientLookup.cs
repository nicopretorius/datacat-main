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
    public delegate void ClientSelectedHandler(Database.Entities.ClientEntity SelectedClient);
    public partial class dlgClientLookup : Form
    {
        public event ClientSelectedHandler ClientSelected;
        public dlgClientLookup()
        {
            InitializeComponent();
        }

        public dlgClientLookup(string Search)
        {
            InitializeComponent();
            LoadClients(Search);

            txtSearch.Text = Search;
            txtSearch.Focus();
        }

        private void ActivateSelection()
        {
            int clientID = Convert.ToInt32(lstClients.SelectedItems[0].Name);
            ClientEntity c = new ClientEntity(clientID);
            if (ClientSelected != null)
            {
                ClientSelected(c);
            }
            this.Close();
        }

        private void LoadClients(string search)
        {
            lstClients.Clear();
            lstClients.Columns.Add("Logo", 200);
            lstClients.Columns.Add("Company Name", 200);
            lstClients.Columns.Add("Telephone", 100);
            lstClients.Columns.Add("Contact Person", 500);
            lstClients.FullRowSelect = true;
            lstClients.HScrollBarDisplayMode = BetterListViewScrollBarDisplayMode.Hide;
            lstClients.GridLines = BetterListViewGridLines.Horizontal;
            lstClients.View = BetterListViewView.Details;
            lstClients.Columns[1].AutoResize(BetterListViewColumnHeaderAutoResizeStyle.HeaderSize);
          
            lstClients.MultiSelect = false;
            try
            {
                using (MySql.Data.MySqlClient.MySqlDataReader reader = Connection.Connection.ExecureReader(@"
                SELECT Client.ID,CompanyName,CompanyTel,ContactPersonName,ContactPersonTel,ThumbNail  
FROM Client
LEFT JOIN Image ON Client.LogoImageID = Image.ID WHERE CompanyName LIKE '%" + search + "%'")
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

                        thumnail =  Utilities.Utilities.ResizeImage(thumnail, new Size(48, 36));
                        BetterListViewItem lstItem = new BetterListViewItem(new[] { reader["ID"].ToString(),
                                                                            reader["CompanyName"].ToString(),
                                                                             reader["CompanyTel"].ToString(),
                                                                              reader["ContactPersonName"].ToString(),
                                                                               reader["ContactPersonTel"].ToString()
                        
                        });
                        lstItem.Name = reader["ID"].ToString();
                        lstItem.Image = thumnail;

                        lstClients.Items.Add(lstItem);

                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }


        }

        private void lstClients_DrawItemBackground(object sender, BetterListViewDrawItemBackgroundEventArgs eventArgs)
        {
            if (eventArgs.Item.Index % 2 == 0)
            {
                Brush brushSelection = new SolidBrush(Color.FromArgb(220,240,255));
                eventArgs.Graphics.FillRectangle(brushSelection, eventArgs.ItemBounds.BoundsSelection);
                brushSelection.Dispose();
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (lstClients.Items.Count == 1)
            {
                ActivateSelection();

            }


            if (lstClients.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void lstClients_DoubleClick(object sender, EventArgs e)
        {
       


            if (lstClients.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadClients(txtSearch.Text);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && lstClients.Items.Count >0)
            {
                lstClients.Focus();
                lstClients.Items[0].Selected = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstClients_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode   == Keys.Enter && lstClients.SelectedItems.Count > 0)
            {
                ActivateSelection();
                
            }
        }

       
    }
}
