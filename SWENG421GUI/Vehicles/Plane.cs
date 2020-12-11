using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Vehicles
{
    public class Plane : Vehicle
    {
        public int range;

        public override void printInfo()
        {
            base.printInfo();
            Console.Write("Range: {0}\n", range);
        }

        public override void setAttribute(string value)
        {
            range = int.Parse(value);
        }
    }
}
