using SWENG421FinalProject.Vehicles;
using SWENG421FinalProject.States;
using System;
using System.Threading;

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




            //Creating a vehicle and setting fields
            VehicleFactory vf = new VehicleFactory();
            Train train1 = (Train) vf.createVehicle("Train");
            Console.WriteLine("Created successfully: {0}", train1 != null);
            train1.identifier = "Train 1";
            train1.loadCount = 5;
            

            //Creating packages and orders
            Crate c1 = new Crate("Crate 1");
            Order o1 = new Order("001", "6 Water Street", "457 West Ave", "Bob Miller", "John Smith", c1);

            Crate c2 = new Crate("Crate 2");
            Order o2 = new Order("002", "50 Route 1", "12 Canal Street", "Jane Morrison", "Ted Jacobs", c2);

            Crate c3 = new Crate("Crate 3");
            Order o3 = new Order("003", "29 Mountain Rd", "521 Pine Blvd", "Nick Johnson", "Robert Ford", c1);

            Crate c4 = new Crate("Crate 4");
            Order o4 = new Order("004", "5 Smith St", "1 Route 60", "Luke Duffy", "Mary Lombardy", c1);

            Crate c5 = new Crate("Crate 5");
            Order o5 = new Order("005", "6 Water Street", "457 West Ave", "Bob Miller", "John Smith", c1);

            Crate c6 = new Crate("Crate 6");
            Order o6 = new Order("006", "50 Route 1", "12 Canal Street", "Jane Morrison", "Ted Jacobs", c2);

            Crate c7 = new Crate("Crate 7");
            Order o7 = new Order("007", "29 Mountain Rd", "521 Pine Blvd", "Nick Johnson", "Robert Ford", c1);

            Crate c8 = new Crate("Crate 4");
            Order o8 = new Order("008", "5 Smith St", "1 Route 60", "Luke Duffy", "Mary Lombardy", c1);

            //Creating routes
            Route rt1 = new Route();
            rt1.toSend.Add(o1);
            rt1.toSend.Add(o2);
            rt1.toSend.Add(o3);
            rt1.toSend.Add(o4);

            Route rt2 = new Route();
            rt2.toSend.Add(o5);
            rt2.toSend.Add(o6);
            rt2.toSend.Add(o7);
            rt2.toSend.Add(o8);

            //Setting Route to vehicle
            train1.setRoute(rt1);

            Company comp1 = new Company("777 Shipping Co");
            comp1.routesToAssign.Add(rt2);
            comp1.vehicles.Add(train1);

            //Running threads
            Thread vehicle1 = new Thread(train1.VehicleThread);
            Thread company1 = new Thread(comp1.CompanyThread);
            vehicle1.Start();
            company1.Start();
        }
    }
}
