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
            Console.WriteLine("Range: {0}\n", range);
        }

        public override string OnCreate()
        {
            return("Company: " + getEnviroment().companyName + " loaded and added Vehicle of type: " + this.getName());
        }

        public override void setAttribute(string value)
        {
            range = double.Parse(value);
        }
    }
}
