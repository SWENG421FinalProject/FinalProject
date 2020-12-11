using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class Box : PalletableIF
    {
        public string Name;
        public Box(string n) {
            this.Name = n;
        }

        //Used by GUI
        public string name
        {
            get { return Name; }
            set { this.Name = value; }
        }

        public string OnCreate()
        {
            return("Company added Shipping Object of type: " + this.GetType().Name);
        }
    }
}
