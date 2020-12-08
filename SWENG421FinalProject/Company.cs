using SWENG421FinalProject.States;
using SWENG421FinalProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SWENG421FinalProject
{
    public class Company
    {
        public List<Vehicle> vehicles;
        public List<Route> routesToAssign;
        public string companyName;
        public Company(string name) {
            this.companyName = name;
            this.vehicles = new List<Vehicle>();
            this.routesToAssign = new List<Route>();
        }
        public Company(string name, List<Vehicle> vs) {
            this.companyName = name;
            this.vehicles = vs;
            this.routesToAssign = new List<Route>();
        }
        public List<Vehicle> getVehicles() {
            return this.vehicles;
        }
        public void setVehicles(List<Vehicle> vs) {
            this.vehicles = vs;
        }

        public void CompanyThread()
        {
            Console.WriteLine("Company {0} starting operations", this.companyName);
            while (this.routesToAssign.Count > 0 && vehicles.Count != 0) {
                Console.WriteLine("Have {0} routes to assign\nChecking {1} vehicles to see if they are ready for a new route", this.routesToAssign.Count, this.vehicles.Count);
                for (int i = 0; i < vehicles.Count; i++) {
                    if (vehicles[i].todo == null && this.routesToAssign.Count > 0)
                    {
                        Console.WriteLine("Adding route to {0}", vehicles[i].identifier);
                        //Assign route
                        vehicles[i].setRoute(routesToAssign[0]);
                        routesToAssign[0].assigned = true;
                        for (int x = 0; x < routesToAssign[0].toSend.Count; x++)
                        {
                            routesToAssign[0].toSend[x].setState(new WaitingInWarehouse());
                        }
                        //Remove route from list
                        this.routesToAssign.RemoveAt(0);
                    }
                    else if (this.routesToAssign.Count > 0)
                    {
                        Console.WriteLine("Vehicle {0} already has a route", vehicles[i].identifier);
                    }
                }
                Console.WriteLine("Company {0} Finished Checking Vehicles", this.companyName);
                if (this.routesToAssign.Count > 0) {
                    Console.WriteLine("Company {0} has {1} Route(s) to assign", this.companyName, this.routesToAssign.Count);
                    Thread.Sleep(5000);
                }
            }
            Console.WriteLine("All routes assigned. Company {0} ending operations", this.companyName);
        }
    }
}
