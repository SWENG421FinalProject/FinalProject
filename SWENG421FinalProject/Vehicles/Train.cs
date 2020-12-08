using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject.Vehicles
{
    public class Train : Vehicle
    {
        public string sizeLimit;
        public Train() {
            base.identifier = "";
            base.loadCount = 0;
            base.mpg = 0.0;
        }
    }
}
