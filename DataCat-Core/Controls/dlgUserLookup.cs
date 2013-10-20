using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using DataCat.Database.Entities;
using DataCat.Utilities;
using DataCat.Connection;

namespace DataCat.Controls
{
    public delegate void UserSelectedHandler(Database.Entities.UserEntity SelectedUser);
    public partial class dlgUserLookup : Form
    {

        public event UserSelectedHandler UserSelected;

        public dlgUserLookup()
        {
            InitializeComponent();
        }

        private void LoadUsers(string search)
        {
            lstUsers.Clear();
            lstUsers.Columns.Add("User Image", 200);
            lstUsers.Columns.Add("User Code", 200);
            lstUsers.Columns.Add("User Name", 800);
            lstUsers.GridLines = BetterListViewGridLines.Horizontal;
            lstUsers.View = BetterListViewView.Details;
            lstUsers.HScrollBarDisplayMode = BetterListViewScrollBarDisplayMode.Hide;
            lstUsers.Columns[1].AutoResize(BetterListViewColumnHeaderAutoResizeStyle.HeaderSize);
            lstUsers.MultiSelect = false;
            lstUsers.FullRowSelect = true;
            try
            {
                using (MySql.Data.MySqlClient.MySqlDataReader reader = Connection.Connection.ExecureReader(@"
                 SELECT User.*,Image.ThumbNail FROM User LEFT JOIN Image ON User.ImageID = Image.ID WHERE UserName like '%"+search+"%'")
                    )
                {

                    while (reader.Read())
                    {
                        Image thumnail;

                        try
                        {
                            MemoryStream MemStream = null;
                            byte[] thumbByte = (byte[]) reader["Thumbnail"];
                            MemStream = new MemoryStream(thumbByte);
                            thumnail = System.Drawing.Image.FromStream(MemStream);
                        }
                        catch (Exception)
                        {
                            thumnail = new Bitmap(100, 100);
                        }

                        thumnail = Utilities.Utilities.ResizeImage(thumnail, new Size(48,36));
                        BetterListViewItem lstItem = new BetterListViewItem(new [] {reader["ID"].ToString(), reader["UserName"].ToString() });
                        lstItem.Name = reader["ID"].ToString();
                        lstItem.Image = thumnail;

                        lstUsers.Items.Add(lstItem);

                    }
                }
            }
            catch (Exception exception)
            {
                Log.Error(exception.Message);
            }

            
        }

        public dlgUserLookup(string Search)
        {
            InitializeComponent();
          
            LoadUsers(Search);

            txtSearch.Text = Search;
            txtSearch.Focus();
        }


        private void ActivateSelection()
        {
            int userID = Convert.ToInt32(lstUsers.SelectedItems[0].Name);
            if (UserSelected != null)
            {
                UserSelected(new UserEntity(userID));
            }
            this.Close();
        }

        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            ActivateSelection();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            if (lstUsers.Items.Count == 1)
            {
               ActivateSelection();
            
            }


            if (lstUsers.SelectedItems.Count > 0)
            {
                ActivateSelection();
            }
        }

        private void dlgUserLookup_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUsers(txtSearch.Text);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) && lstUsers.Items.Count >0 )
            {
                lstUsers.Focus();
                lstUsers.Items[0].Selected = true;
            }
        }

        private void lstUsers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstUsers.SelectedItems.Count > 0)
                {
                    ActivateSelection();
                }
            }
        }

        private void dlgUserLookup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            
        }

        private void lstUsers_DrawItemBackground(object sender, BetterListViewDrawItemBackgroundEventArgs eventArgs)
        {
            if (eventArgs.Item.Index % 2 == 0)
            {
                Brush brushSelection = new SolidBrush(Color.FromArgb(220,240,255));
                eventArgs.Graphics.FillRectangle(brushSelection, eventArgs.ItemBounds.BoundsSelection);
                brushSelection.Dispose();
            }
        
        }

   
    }
}
