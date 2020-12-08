using SWENG421FinalProject.Vehicles;
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
            //Create Packages
            Crate c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
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

            Barrel br1, br2, br3;
            br1 = new Barrel("Barrel 1");
            br2 = new Barrel("Barrel 2");
            br3 = new Barrel("Barrel 3");

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
                                                            br1, br2, br3, p1, p2, p3, p4, p5};
            //Create Orders
            initOrders(packagesToAssign, ordersToAssign);

            //Create Routes
            initRoutes(ordersToAssign, routesToAssign);

            for (int i = 0; i < routesToAssign.Count; i++) {
                Console.WriteLine("Route {0}", i);
                for (int j = 0; j < routesToAssign[i].toSend.Count; j++) {
                    Console.WriteLine("Package {0}: {1}", j, routesToAssign[i].toSend[j].trackingNumber);
                }
            }

            //Create Vehicles
            //Create Company

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
    }
}
