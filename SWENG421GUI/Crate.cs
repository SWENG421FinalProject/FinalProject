using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class Crate : ShippingObjectIF
    {
        public string Name;
        public Crate(string n) {
            this.Name = n;
        }

        //Used by GUI
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public void OnCreate()
        {
            Console.WriteLine("Company added Shipping Object of type: " + this.GetType().Name);
        }
    }
}
