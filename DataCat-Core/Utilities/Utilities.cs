using System;
using WebCam_Capture;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DataCat.Utilities
{

    public static class Log
    {
        public static void Information(string infoMessage, ConsoleColor color)
        {
            Console.WriteLine(infoMessage, color);
        }

        public static void Verbose(string logMessage)
        {
            Console.WriteLine(logMessage);
        }

        public static void Error(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(errorMessage, ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
    
    

   

    public static class Utilities
    {
        public static ComboBoxItem GetComboBoxSelection(ComboBox cmb)
        {
            if (cmb.SelectedIndex != -1)
            {
                return (ComboBoxItem)cmb.SelectedItem;
            }
            else
            {
                return new ComboBoxItem(cmb.Text, "-1");
            }
        }

        public static void SetComboBoxId(ComboBox cmb, string id)
        {

            if (id == "-1")
            {
                Console.WriteLine("Cannot set ID to -1");
                cmb.SelectedIndex = -1;
            }
            foreach (ComboBoxItem item in cmb.Items)
            {
                if ( item.HiddenValue.ToString() == id)
                {
                    cmb.SelectedItem = item;
                    Console.WriteLine("Setting item to " + item.ToString());
                    return;
                }
            }
            Console.WriteLine("Couldn Not locate value in combobox" + id.ToString());
            cmb.SelectedIndex = -1;


        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            var sourceWidth = imgToResize.Width;
            var sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            var b = new Bitmap(destWidth, destHeight);
            var g = Graphics.FromImage((Image)b);
     

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        public static Image GetLogo()
        { 
            Image img = Image.FromFile("Media\\Logo.png");

            return img;
        }


    }

    public class WebCam
    {
        private WebCamCapture webcam;
        private System.Windows.Forms.PictureBox _FrameImage;
        private int FrameNumber = 30;
        public void InitializeWebCam(ref System.Windows.Forms.PictureBox ImageControl)
        {
            webcam = new WebCamCapture();
            webcam.FrameNumber = ((ulong)(0ul));
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
            _FrameImage = ImageControl;
        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _FrameImage.Image = e.WebCamImage;
        }

        public void Start()
        {
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.Start(0);
        }

        public void Stop()
        {
            webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            webcam.Start(this.webcam.FrameNumber);
        }

        public void ResolutionSetting()
        {
            webcam.Config();
          
        }

        public void AdvanceSetting()
        {
            webcam.Config2();
        }

         public static void SaveImageCapture(string FileName,System.Drawing.Image image)
         {
            FileStream fstream = new FileStream(FileName, FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();

         }
    }



   public class ComboBoxItemWithParent : ComboBoxItem
   {
       public ComboBoxItemWithParent(string displayName,object valueMember, int parentID)
           : base(displayName,valueMember)
       {
           this.ParentID = parentID;
       }

       public int ParentID { get; set; }
   }


    public class ComboBoxItem
    {
        public string displayValue;
        

        object hiddenObject;


        //Constructor
        public ComboBoxItem(string d, object o)
        {
            displayValue = d;
            hiddenObject = o;
        }

        //Accessor
        public object HiddenValue
        {
            get
            {
                return hiddenObject;
            }
        }

        //Override ToString method
            public override string ToString()
        {
            return displayValue;
        }
    }
}


