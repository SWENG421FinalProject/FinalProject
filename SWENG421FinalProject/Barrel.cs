using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Barrel : PalletableIF
    {
        public string name;
        public Barrel(string n) {
            this.name = n;
        }
    }
}
