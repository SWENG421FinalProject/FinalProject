﻿using SWENG421FinalProject.Vehicles;
using SWENG421FinalProject.States;
using System;
using System.Threading;
using System.Collections.Generic;

namespace SWENG421FinalProject
{
    class Program
    {
        public static Random r = new Random();
        static void Main(string[] args)
        {
            List<ShippingObjectIF> packagesToAssign;
            List<Order> ordersToAssign = new List<Order>();
            List<Route> routesToAssign = new List<Route>();
            List<Vehicle> vehicleList = new List<Vehicle>();
            //Create Packages
            Crate c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20;
            c1 = new Crate("Crate 1");
            c2 = new Crate("Crate 2");
            c3 = new Crate("Crate 3");
            c4 = new Crate("Crate 4");
            c5 = new Crate("Crate 5");
            c6 = new Crate("Crate 6");
            c7 = new Crate("Crate 7");
            c8 = new Crate("Crate 8");
            c9 = new Crate("Crate 9");
            c10 = new Crate("Crate 10");
            c11 = new Crate("Crate 11");
            c12 = new Crate("Crate 12");
            c13 = new Crate("Crate 13");
            c14 = new Crate("Crate 14");
            c15 = new Crate("Crate 15");
            c16 = new Crate("Crate 16");
            c17 = new Crate("Crate 17");
            c18 = new Crate("Crate 18");
            c19 = new Crate("Crate 19");
            c20 = new Crate("Crate 20");

            Barrel br1, br2, br3, br4, br5, br6, br7, br8, br9, br10, br11, br12, br13, br14, br15;
            br1 = new Barrel("Barrel 1");
            br2 = new Barrel("Barrel 2");
            br3 = new Barrel("Barrel 3");
            br4 = new Barrel("Barrel 4");
            br5 = new Barrel("Barrel 5");
            br6 = new Barrel("Barrel 6");
            br7 = new Barrel("Barrel 7");
            br8 = new Barrel("Barrel 8");
            br9 = new Barrel("Barrel 9");
            br10 = new Barrel("Barrel 10");
            br11 = new Barrel("Barrel 11");
            br12 = new Barrel("Barrel 12");
            br13 = new Barrel("Barrel 13");
            br14 = new Barrel("Barrel 14");
            br15 = new Barrel("Barrel 15");

            Box bx1, bx2, bx3, bx4, bx5;
            bx1 = new Box("Box 1");
            bx2 = new Box("Box 2");
            bx3 = new Box("Box 3");
            bx4 = new Box("Box 4");
            bx5 = new Box("Box 5");

            Pallet p1, p2, p3, p4, p5;
            p1 = new Pallet("Pallet 1", bx1);
            p2 = new Pallet("Pallet 2", bx2);
            p3 = new Pallet("Pallet 3", bx3);
            p4 = new Pallet("Pallet 4", bx4);
            p5 = new Pallet("Pallet 5", bx5);

            packagesToAssign = new List<ShippingObjectIF> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,
                                                            c11, c12, c13, c14, c15, c16, c17, c18, c19,
                                                            c20, br1, br2, br3, br4, br5, br6, br7, br8,
                                                            br9, br10, br11, br12, br13, br14, br15, p1, 
                                                            p2, p3, p4, p5};
            //Create Orders
            initOrders(packagesToAssign, ordersToAssign);

            //Create Routes
            initRoutes(ordersToAssign, routesToAssign);

            //Test that packages, orders, and routes were created successfully
            for (int i = 0; i < routesToAssign.Count; i++) {
                Console.WriteLine("Route {0}", i);
                for (int j = 0; j < routesToAssign[i].toSend.Count; j++) {
                    Console.WriteLine("Package {0}: {1}", j, routesToAssign[i].toSend[j].trackingNumber);
                }
            }

            //Create Vehicles
            VehicleFactory vf = new VehicleFactory();
            RoadVehicle Truck1, Truck2;
            Train Train1, Train2, Train3;

            Truck1 = (RoadVehicle)vf.createVehicle("Truck");
            Truck2 = (RoadVehicle)vf.createVehicle("Truck");
            Train1 = (Train)vf.createVehicle("Train");
            Train2 = (Train)vf.createVehicle("Train");
            Train3 = (Train)vf.createVehicle("Train");

            Truck1.identifier = "Truck 1";
            Truck1.loadCount = 5;
            Truck1.mpg = 15.0;
            Truck1.todo = null;
            Truck1.license = "B";

            Truck2.identifier = "Truck 2";
            Truck2.loadCount = 10;
            Truck2.mpg = 10.0;
            Truck2.todo = null;
            Truck2.license = "A";

            Train1.identifier = "Train 1";
            Train1.loadCount = 15;
            Train1.mpg = 30.0;
            Train1.todo = null;
            Train1.gauge = "Standard";

            Train2.identifier = "Train 2";
            Train2.loadCount = 15;
            Train2.mpg = 35.0;
            Train2.todo = null;
            Train2.gauge = "Standard";

            Train3.identifier = "Train 3";
            Train3.loadCount = 15;
            Train3.mpg = 50.0;
            Train3.todo = null;
            Train3.gauge = "Narrow";

            vehicleList.Add(Truck1);
            vehicleList.Add(Truck2);
            vehicleList.Add(Train1);
            vehicleList.Add(Train2);
            vehicleList.Add(Train3);

            //Create Company
            Company myCompany = new Company("Shipping Co");
            myCompany.vehicles = vehicleList;
            myCompany.routesToAssign = routesToAssign;

            Thread companyThread = new Thread(myCompany.CompanyThread);
            Thread vehicleThread1 = new Thread(Truck1.VehicleThread);
            Thread vehicleThread2 = new Thread(Truck2.VehicleThread);
            Thread vehicleThread3 = new Thread(Train1.VehicleThread);
            Thread vehicleThread4 = new Thread(Train2.VehicleThread);
            Thread vehicleThread5 = new Thread(Train3.VehicleThread);

            //for (int i = 0; i < myCompany.vehicles.Count; i++) { 
            //
            //}
            companyThread.Start();
            vehicleThread1.Start();
            vehicleThread2.Start();
            vehicleThread3.Start();
            vehicleThread4.Start();
            vehicleThread5.Start();

            //Run Program
            //Multiple threads start
            //Company assigns routes
            //Vehicles goes on routes
            //Order state changes

            //Running threads
            //Thread vehicle1 = new Thread(train1.VehicleThread);
            //Thread company1 = new Thread(comp1.CompanyThread);
            //vehicle1.Start();
            //company1.Start();
        }

        private static void initOrders(List<ShippingObjectIF> packagesToAssign, List<Order> ordersToAssign)
        {
            Order currentOrder;
            Random r = new Random();
            string trackingNum;
            string startAddress;
            string finishAddress;
            string startName;
            string endName;
            for (int i = 0; i < packagesToAssign.Count; i++) {
                trackingNum = r.Next(0, 999).ToString("000");
                startAddress = genAddress();
                finishAddress = genAddress();
                startName = genName();
                endName = genName();

                currentOrder = new Order(trackingNum, startAddress, finishAddress, startName, endName, packagesToAssign[i]);
                ordersToAssign.Add(currentOrder);
            }
        }

        private static string genName()
        {
            string ans = "";
            int select;
            string[] firstNames = { "Joe", "John", "Robert", "Michael", "David", "Joseph", "Thomas",
                                    "Mary", "Susan", "Sara", "Leah", "Jessica", "Donna", "Ashley"};
            string[] lastNames = { "Smith", "Johnson", "Williams", "Lee", "Anderson", "Jones", "Miller",
                                    "Davis", "Moore", "Martin", "Thompson", "Harris", "Robinson", "Walker" };
            
            select = r.Next(0, firstNames.Length-1);
            ans += firstNames[select] + " ";
            select = r.Next(0, lastNames.Length-1);
            ans += lastNames[select];
            return ans;
        }

        private static string genAddress()
        {
            string ans = "";
            
            string num = r.Next(1, 999).ToString("000");
            ans += num + " ";

            int select;
            string[] names = { "First", "Second", "Water", "Pine", "Mill", "Canal", "North", "South", "East", "West" };
            string[] title = { "St", "Ave", "Blvd", "Rd", "Ln" };
            
            select = r.Next(0, names.Length - 1);
            ans += names[select] + " ";

            select = r.Next(0, title.Length - 1);
            ans += title[select];

            return ans;
        }

        private static void initRoutes(List<Order> ordersToAssign, List<Route> routesToAssign)
        {
            Route currentRoute;
            for (int i = 0; i < ordersToAssign.Count; i += 5) {
                //Create Route with next 5 packages;
                currentRoute = new Route();
                currentRoute.toSend.Add(ordersToAssign[i]);
                
                //Check that the next 4 are not out of range and assign them
                if (i + 1 < ordersToAssign.Count) {
                    currentRoute.toSend.Add(ordersToAssign[i + 1]);
                }
                if (i + 2 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 2]);
                }
                if (i + 3 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 3]);
                }
                if (i + 4 < ordersToAssign.Count)
                {
                    currentRoute.toSend.Add(ordersToAssign[i + 4]);
                }
                
                //Add route
                routesToAssign.Add(currentRoute);
            }

        }
        private static void initVehicles(List<Vehicle> vehicleList)
        {

        }
    }
}
