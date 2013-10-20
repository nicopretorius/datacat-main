using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DataCat.Plugins
{
    public interface IPlugin
    {
        void Initialize();
    }

    public interface IPluginFactory
    {
        string GetPluginName();

        string GetDescription();

        int PluginID();

        Control GetControl();

        Image GetImage();      
    }
}
