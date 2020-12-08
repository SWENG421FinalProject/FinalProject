using SWENG421FinalProject.Vehicles;
using SWENG421FinalProject.States;
using System;

namespace SWENG421FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Packages
            //Create Orders
            //Create Routes
            //Create Vehicles
            //Create Company

            //Run Program
            //Multiple threads start
            //Company assigns routes
            //Vehicles goes on routes
            //Order state changes
            
            VehicleFactory vf = new VehicleFactory();
            Train train1 = (Train) vf.createVehicle("Train");
            Console.WriteLine("Created successfully: {0}", train1 != null);
        }
    }
}
