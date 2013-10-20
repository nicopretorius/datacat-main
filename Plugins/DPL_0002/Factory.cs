using System;
using System.Collections.Generic;
using System.Text;
using DataCat.Plugins;
using System.Drawing;


namespace DPL_0002
{
    public class Factory : IPluginFactory
    {
        public System.Windows.Forms.Control GetControl()
        {
            return new ClientMaintenance();
        }

        public string GetDescription()
        {
            return "Clients";
        }

        public System.Drawing.Image GetImage()
        {
            return Resource1.Clients;
        }

        public string GetPluginName()
        {
            return "Clients";
        }

        public int PluginID()
        {
            return 2;
        }

        public override string ToString()
        {
            return "Clients";
        }
    }
}
