using System;
using System.Collections.Generic;
using System.Text;
using DataCat.Plugins;
using System.Drawing;
using System.ComponentModel.Composition;
using System.Windows.Forms;
namespace DPL_0001 
{
    public class Factory : IPluginFactory
    {

        public System.Windows.Forms.Control GetControl()
        {
            return new UserMaintenance();
        }

        public string GetDescription()
        {
            return "User Maintenance";
        }

        public System.Drawing.Image GetImage()
        {
            return DPL_0001.Resource1.User;
        }

        public string GetPluginName()
        {
            return "User Maintenance";
        }

        public int PluginID()
        {
            return 1;  
        }

        public override string ToString()
        {
            return "User Maintenance";
        }
    }
}
