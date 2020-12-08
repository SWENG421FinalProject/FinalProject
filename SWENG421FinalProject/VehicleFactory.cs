using SWENG421FinalProject.Vehicles;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class VehicleFactory
    {
        public Vehicle createVehicle(string type) {
            Vehicle ans;
            type = type.ToLower();
            if (type == "roadvehicle")
            {
                Console.WriteLine("Creating new Road Vehicle");
                ans = new RoadVehicle();
            }
            else if (type == "train")
            {
                Console.WriteLine("Creating new Train");
                ans = new Train();
            }
            else if (type == "ship")
            {
                Console.WriteLine("Creating new Ship");
                ans = new Ship();
            }
            else if (type == "plane")
            {
                Console.WriteLine("Creating new Plane");
                ans = new Plane();
            }
            else {
                //string[] vehicleFiles = Directory.GetFiles("\\");
                //int trim = 0;
                //for (int i = 0; i < vehicleFiles.Length; i++) {
                //    trim = vehicleFiles[i].IndexOf(".");
                //    vehicleFiles[i] = vehicleFiles[i].Substring(0, trim);
                //    vehicleFiles[i] = vehicleFiles[i].ToLower();
                //    Console.WriteLine("Vehicle File {0} = {1}", i, vehicleFiles[i]);
                //    if (vehicleFiles[i] == type) {
                //        ans = (Vehicle) Activator.CreateInstance(Type.GetType(vehicleFiles[i]));
                //    }
                //}
                Console.WriteLine("Vehicle Type Not Recognized");
            }

            return null;
        }
    }
}
