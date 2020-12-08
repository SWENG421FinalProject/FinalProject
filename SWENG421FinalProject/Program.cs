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
            
            VehicleFactory vf = new VehicleFactory();
            Train train1 = (Train) vf.createVehicle("Train");
            Console.WriteLine("Created successfully: {0}", train1 != null);

            //Company c1 = new Company("Shipping Co");

            train1.identifier = "Train 1";
            train1.loadCount = 5;
            

            Crate c1 = new Crate("Crate 1");
            Order o1 = new Order("001", "6 Water Street", "457 West Ave", "Bob Miller", "John Smith", c1);

            Crate c2 = new Crate("Crate 2");
            Order o2 = new Order("002", "50 Route 1", "12 Canal Street", "Jane Morrison", "Ted Jacobs", c2);

            Crate c3 = new Crate("Crate 3");
            Order o3 = new Order("003", "29 Mountain Rd", "521 Pine Blvd", "Nick Johnson", "Robert Ford", c1);

            Crate c4 = new Crate("Crate 4");
            Order o4 = new Order("004", "5 Smith St", "1 Route 60", "Luke Duffy", "Mary Lombardy", c1);

            Route rt1 = new Route();
            rt1.toSend.Add(o1);
            rt1.toSend.Add(o2);
            rt1.toSend.Add(o3);
            rt1.toSend.Add(o4);

            train1.setRoute(rt1);

            Thread vehicle1 = new Thread(train1.VehicleThread);
            //Thread company1 = new Thread(c1.CompanyThread);
            vehicle1.Start();
            //company1.Start();
        }
    }
}
