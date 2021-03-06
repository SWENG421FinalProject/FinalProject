﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class Pallet : ShippingObjectIF
    {
        public PalletableIF myObject;
        public string Name;
        public Pallet(string n, PalletableIF package) {
            this.Name = n;
            this.myObject = package;
        }

        //Used by GUI
        public string name { get { return Name; }
            set { this.Name = value; }
        }

        public string OnCreate()
        {
            return("Company added Shipping Object of type: " + this.GetType().Name);
        }
    }
}
