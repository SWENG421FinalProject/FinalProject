using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public interface ShippingObjectIF
    {
        //Name variable added so that the GUI can get the package's name
        string name { get; set; }
    }
}
