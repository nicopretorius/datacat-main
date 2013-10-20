using System;
using System.Collections.Generic;
using System.Text;
using DataCat.Plugins;
using System.Drawing;

using System.Reflection;
using System.Resources;
namespace DPL_0004
{
    public class Factory : IPluginFactory
    {
        public System.Windows.Forms.Control GetControl()
        {
            return new ProjectMaintenance();
        }

        public string GetDescription()
        {
            return "Project";
        }

        public System.Drawing.Image GetImage()
       {
           return Resource1.Job;
        }

        public string GetPluginName()
        {
            return "Project";
        }

        public int PluginID()
        {
            return 4;
        }

        public override string ToString()
        {
            return "Project";
        }
    }
}
