using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Vehicles
{
    public class Ship : Vehicle
    {
        public string gauge;
        public override void printInfo()
        {
            base.printInfo();
            Console.Write("Gauge: {0}\n", gauge);
        }
    }
}
