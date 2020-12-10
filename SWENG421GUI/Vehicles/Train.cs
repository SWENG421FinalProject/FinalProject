using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Vehicles
{
    public class Train : Vehicle
    {
        public string gauge;
        public Train() {
            base.identifier = "";
            base.loadCount = 0;
            base.mpg = 0.0;
            gauge = "";
        }
        public override void printInfo()
        {
            base.printInfo();
            Console.Write("Gauge: {0}\n", gauge);
        }
    }
}
