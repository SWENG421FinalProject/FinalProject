using SWENG421GUI.Vehicles;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class VehicleFactory
    {
        public Vehicle createVehicle(string type) {
            Vehicle ans = null;
            type = type.ToLower();
            type = type.Substring(type.LastIndexOf('.') + 1);
            if (type == "roadvehicle" || type == "truck" || type == "van" || type == "car")
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

            ans.identifier = "";
            ans.loadCount = 0;
            ans.mpg = 0;
            ans.todo = null;

            return ans;
        }
    }
}
