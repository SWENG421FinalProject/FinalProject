using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Pallet : ShippingObjectIF
    {
        public PalletableIF myObject;
        public string name;
        public Pallet(string n, PalletableIF package) {
            this.name = n;
            this.myObject = package;
        }
    }
}
