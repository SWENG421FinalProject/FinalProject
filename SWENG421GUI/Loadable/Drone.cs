using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Loadable
{
    class Drone : AbstractLoadableVehicle
    {
        int range;

        public override string getName()
        {
            return (this.GetType().Name);
        }

        public override void printInfo()
        {
            Console.WriteLine("Range (miles): {0}\n", range);
        }
    }
}
