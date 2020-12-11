using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Vehicles
{
    public class RoadVehicle : Vehicle
    {
        public string license;
        public override void printInfo()
        {
            base.printInfo();
            Console.Write("License: {0}\n", license);
        }

        public override void setAttribute(string value)
        {
            license = value;
        }
    }
}
