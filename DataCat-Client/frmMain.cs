using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DataCat.Plugins;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Threading;
using DataCat.Utilities;

namespace DataCat_Client
{
    public partial class frmMain : Form
    {
        #region Constructors

        public frmMain()
        {
            InitializeComponent();
            LoadPlugins();
        }

        #endregion

        #region Fields

        List<IPluginFactory> list_Plugins = new List<IPluginFactory>();
        Dictionary<int, IPluginFactory> PluginDict = new Dictionary<int, IPluginFactory>();

        #endregion

        #region Methods


        private void LoadPlugins()
        {
            lstMenu.Clear();
            lstMenu.View = ComponentOwl.BetterListView.BetterListViewView.LargeIcon;
            lstMenu.Columns.Add("Thumbnail");
            lstMenu.MultiSelect = false;

            foreach (string s in Directory.GetFiles(Application.StartupPath.ToString(), "*.dll"))
            {
                try
                {
                    Type[] pluginTypes = Assembly.LoadFile(s).GetTypes();
                    foreach (Type t in pluginTypes)
                    {

                        if (t.ToString().Contains(".Factory"))
                        {
                            IPluginFactory plugin = Activator.CreateInstance(t) as IPluginFactory;
                            list_Plugins.Add(plugin);
                            PluginDict.Add(plugin.PluginID(), plugin);
                            var lstItem = new ComponentOwl.BetterListView.BetterListViewItem
                            {
                                Name = plugin.PluginID().ToString(),
                                Text = plugin.GetPluginName(),
                                Image = plugin.GetImage()
                            };

                            lstMenu.Items.Add(lstItem);
                        }
                    }
                }
                catch (TypeLoadException e)
                {
                    MessageBox.Show(e.Message);
                    continue;
                }
            }

           // lstMenu.DataSource = list_Plugins;
        }

        #endregion

        #region Events        

        private IPluginFactory GetPlugin(int inID)
        {
            foreach (IPluginFactory p in list_Plugins)
            {
                if (p.PluginID() == inID)
                    return p;

            }
            return null;
        }         

        private void lstMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void lstMenu_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lstMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {         
            int SelectedID = -1;
            try
            {
                SelectedID = Convert.ToInt32(lstMenu.SelectedItems[0].Name);
            }
            catch
            {
                SelectedID = -1;
            }

            if (SelectedID > 0)
            {
                IPluginFactory plugin = GetPlugin(SelectedID);
                if (plugin.GetControl() is IPlugin)
                {
                    IPlugin p = plugin.GetControl() as IPlugin;
                    tcMain.TabPages.Add(plugin.GetPluginName() + "    x");
                    tcMain.TabPages[tcMain.TabPages.Count - 1].Controls.Add((Control)p);
                    tcMain.SelectTab(tcMain.TabPages[tcMain.TabPages.Count - 1]);

                    p.Initialize();
                }
                else
                    return;
            }
        }


        private void tcMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tcMain.TabPages.Count; i++)
            {
                if (i == 0) continue;
                Rectangle r = tcMain.GetTabRect(i);

                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close the " + this.tcMain.TabPages[i].Text.Replace("    x", "") + " Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tcMain.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void PopulateImage()
        {
            Shared.userEntity.LoadThumbNail();
            pbProfilePic.Image = Shared.userEntity.ThumbNail;
            Shared.userEntity.LoadProfileImage();
            pbProfilePic.Image = Shared.userEntity.ProfileImage;
        }

        private void LogIn()
        {         

            pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
            Thread t = new Thread(PopulateImage);
            t.Start();
            lblUserName.Text = Shared.userEntity.UserName;
            this.Text = "DataCat            Active User - " + Shared.userEntity.UserName;
        }


        private void Form1_Load(object sender, EventArgs e)
        {           
            frmLogin login = new frmLogin();
            //login.LoginSuccess += new LoginSuccessHandler(login_LoginSuccess);
            login.ShowDialog();

            if (Shared.Loginauthorized == false)
                this.Dispose();

            if (Shared.userEntity.UserName != "")
            {
                LogIn();
            }

            lstMenu.BackgroundImage = Utilities.GetLogo();
            lstMenu.BackgroundImageLayout = ImageLayout.Zoom;
            lstMenu.BackgroundImageOpacity = 40;
        }

        void login_LoginSuccess(string username)
        {

        }

        #endregion
    }
}
