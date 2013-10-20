using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DataCat.Plugins;
using DataCat.Connection;
using DataCat.Utilities;
using DataCat.Database.Entities;
namespace DPL_0001
{
    public partial class UserMaintenance : UserControl,IPlugin
    {
     public enum EditState
        {
            Browse = 0,
            Create = 1,
            Edit = 2
        }

         public UserMaintenance()
         {
             InitializeComponent();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
            
 
        }
        WebCam webcam;
        EditState curState;

        private void ClearControls()
        {
            txtConfirmPassword.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            txtUserName.Text = "";
            imgVideo.Image = new Bitmap(100,100);
        }

        private void ChangeEditState(EditState NewEditState)
        {
            curState = NewEditState;
            if (curState == EditState.Browse)
            {
                ClearControls();
                grpNewUser.Visible = true;
                webcam.Stop();
                grpNewUser.Enabled = false;
                grpUserSearch.Enabled = true;
                userLookup1.Clear();
                userLookup1.Focus();
                userLookup1.Focus();
                

                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnCancelClose.Enabled = true;
                userLookup1.GrabFocus();
            }
            else if (curState == EditState.Create)
            {
                ClearControls();
                grpNewUser.Visible = true;
                grpNewUser.Enabled = true;
                grpUserSearch.Enabled = false;
                txtUserName.Focus();

                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnCancelClose.Enabled = true;
            }
            else if (curState == EditState.Edit)
            {
                ClearControls();
                grpNewUser.Visible = true;
                btnCapture.Enabled = false;
                grpNewUser.Enabled = true;
                grpUserSearch.Enabled = false;
                txtUserName.Focus();

                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnCancelClose.Enabled = true;
            }
        }


        public string Get_Name()
        {
            return "User Management";
        }

        UserEntity curUser = new UserEntity();
  
        private void PopulateImage()
        {
            curUser.LoadThumbNail();

            imgVideo.Image = curUser.ThumbNail;

            curUser.LoadProfileImage();

            imgVideo.Image = curUser.ProfileImage;
        }

        private void PopulateCurrentUser()
        {
            imgVideo.SizeMode = PictureBoxSizeMode.Zoom;

            System.Threading.Thread t = new Thread(PopulateImage);
            t.Start();
            txtUserID.Text = curUser.ID.ToString();
            txtUserName.Text = curUser.UserName.ToString();
            txtPassword.Text = curUser.Password.ToString();
            txtConfirmPassword.Text = curUser.Password.ToString();
            ImageChanged = false;
        }

        private bool ImageChanged;

        public string GetPluginId()
        {
            return this.Name;
        }

        public string GetPluginName()
        {
            return this.Text;
        }

        public void Initialize()
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            ChangeEditState(EditState.Create);
            curUser = new UserEntity();
            PopulateCurrentUser();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ImageChanged) curUser.ImageID = Connection.SaveImage(imgVideo.Image);
            curUser.Password = txtPassword.Text;
            curUser.UserName = txtUserName.Text;
            curUser.Save();

            ChangeEditState(EditState.Browse);
        }

        private void btnNewPic_Click_1(object sender, EventArgs e)
        {
            webcam.Continue();
            webcam.Stop();
            webcam.Start();

            btnNewPic.Enabled = false;
            btnLoad.Enabled = false;
            btnCapture.Enabled = true;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Image myImage = imgVideo.Image;

            webcam.Stop();
            imgVideo.Image = myImage;

            ImageChanged = true;
            btnCapture.Enabled = false;
            btnLoad.Enabled = true;
            btnNewPic.Enabled = true;
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            ChangeEditState(EditState.Browse);
        }

        private void userLookup1_UserSelected(UserEntity SelectedUser)
        {
            curUser = SelectedUser;
            ChangeEditState(EditState.Edit);
            PopulateCurrentUser();  
        }

        private OpenFileDialog dlgOpen;
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlgOpen.FileOk += new System.ComponentModel.CancelEventHandler(dlgOpen_FileOk);
            dlgOpen.ShowDialog();

        }

        void dlgOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imgVideo.Image = Image.FromFile(dlgOpen.FileName);
            ImageChanged = true;

        }

        private void UserMaintenance_Load(object sender, EventArgs e)
        {
            ChangeEditState(EditState.Browse);
        }
    }
}
