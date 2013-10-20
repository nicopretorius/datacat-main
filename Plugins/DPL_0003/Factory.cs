using System;
using System.Collections.Generic;
using System.Text;
using DataCat.Plugins;

namespace DPL_0003
{
    public class Factory : IPluginFactory
    {
        public System.Windows.Forms.Control GetControl()
        {
            return new MaintainPerson();
        }

        public string GetDescription()
        {
            return "Person";
        }

        public System.Drawing.Image GetImage()
        {
           return Resource1.Person;
        }

        public string GetPluginName()
        {
            return "Person";
        }

        public int PluginID()
        {
            return 3;
        }

        public override string ToString()
        {
            return "Person";
        }
    }
}
