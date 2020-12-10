using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Loadable
{
    class Drone : AbstractLoadableVehicle
    {
        double range;

        public override string getName()
        {
            return (this.GetType().Name);
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Range (miles): {0}\n", range);
        }

        public override void setAttribute(double value)
        {
            range = value;
        }
    }
}
