using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    abstract class AbstractLoadableVehicle : Vehicle
    {
        private Company enviroment;

        public void setEnviroment(Company company)
        {
            enviroment = company;
        }

        protected Company getEnviroment()
        {
            return enviroment;
        }

        public abstract string getName();

        public override void printInfo()
        {
            base.printInfo();
        }

        public abstract void setAttribute(double value);
    }
}
