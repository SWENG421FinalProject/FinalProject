using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Box : PalletableIF
    {
        public string name;
        public Box(string n) {
            this.name = n;
        }
    }
}
