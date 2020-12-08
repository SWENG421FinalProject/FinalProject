using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Crate : ShippingObjectIF
    {
        public string name;
        public Crate(string n) {
            this.name = n;
        }
    }
}
