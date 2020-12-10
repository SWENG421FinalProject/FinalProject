using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Loadable
{
    class Drone : AbstractLoadableClass
    {
        int flightTime;
        int range;

        public override string getName()
        {
            return (this.GetType().Name);
        }

        public override void printInfo()
        {
            Console.WriteLine("Flight time (minutes): {0}\nRange (miles): {1}\n", flightTime, range);
        }
    }
}
