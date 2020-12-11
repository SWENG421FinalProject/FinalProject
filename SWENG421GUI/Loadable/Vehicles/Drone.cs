using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI.Loadable.Vehicles
{
    class Drone : AbstractLoadableVehicle
    {
        public double range;

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

        public override void OnCreate()
        {
            Console.WriteLine("Company: " + getEnviroment().companyName + " loaded and added Vehicle of type: " + this.getName());
        }
    }
}
