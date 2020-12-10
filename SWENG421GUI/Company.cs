using SWENG421GUI.States;
using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SWENG421GUI
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

        //Uses a RichTextBox to write output to
        public void CompanyThread(RichTextBox rtb, List<State> stateList)
        {
            //Use variable rather than removing routes from list
            int routesLeft = routesToAssign.Count;

            //Write output to textbox instead of the console
            //rtb.Text += "Company " + this.companyName + " starting operations\n";
            Console.WriteLine("Company {0} starting operations", this.companyName);
            
            //Keep running until all routes are assigned
            while (routesLeft > 0 && vehicles.Count != 0) {
                //rtb.Text += "Have " + this.routesToAssign.Count + " routes to assign\nChecking " + this.vehicles.Count + " vehicles to see if they are ready for a new route\n";
                Console.WriteLine("Have {0} routes to assign\nChecking {1} vehicles to see if they are ready for a new route", this.routesToAssign.Count, this.vehicles.Count);

                //Check all vehicles to see if any are ready for a new route
                for (int i = 0; i < vehicles.Count; i++) {
                    for (int j = 0; j < this.routesToAssign.Count; j++) {
                        if (routesToAssign[j].assigned == false)
                        {
                            //If a vehicle doesn't have a route, assign it one
                            if (vehicles[i].todo == null && routesLeft > 0)
                            {
                                //rtb.Text += "Adding route to " + vehicles[i].identifier + "\n";
                                Console.WriteLine("Adding route to {0}", vehicles[i].identifier);
                                //Assign route
                                vehicles[i].setRoute(routesToAssign[j]);
                                routesToAssign[j].assigned = true;
                                for (int x = 0; x < routesToAssign[j].toSend.Count; x++)
                                {
                                    routesToAssign[j].toSend[x].setState(stateList[2]);
                                }
                                //Remove route from list
                                //this.routesToAssign.RemoveAt(0);
                                routesLeft--;
                            }
                            //Else print out a message if there are still routes to assign
                            else if (routesLeft > 0)
                            {
                                //rtb.Text += "Vehicle " + vehicles[i].identifier + " already has a route\n";
                                Console.WriteLine("Vehicle {0} already has a route", vehicles[i].identifier);
                            }
                        }
                    } 
                }

                //Print message at end of loop
                //rtb.Text += "Company " + this.companyName + " Finished Checking Vehicles\n";
                Console.WriteLine("Company {0} Finished Checking Vehicles", this.companyName);
                
                //Wait if there are still routes to assign
                if (routesLeft > 0) {
                    //rtb.Text += "Company " + this.companyName + " has " + this.routesToAssign.Count + " Routes(s) to assign\n"; 
                    Console.WriteLine("Company {0} has {1} Route(s) to assign", this.companyName, this.routesToAssign.Count);
                    Thread.Sleep(5000);
                }
            }

            //Loop finished
            //rtb.Text += "All routes assigned. Company " + this.companyName + " ending operations\n";
            Console.WriteLine("Company {0} assigned all its routes. Confirming packages were delivered", this.companyName);
            bool done = false;
            while (!(done)){
                done = true;
                Console.WriteLine("Company {0} checking in packages", this.companyName);
                for (int i = 0; i < this.routesToAssign.Count; i++) {
                    for (int j = 0; j < this.routesToAssign[i].toSend.Count; j++) {
                        if (this.routesToAssign[i].toSend[j].getState() == stateList[4])
                        {
                            Console.WriteLine("Company {0} Checking in package {1}", this.companyName, this.routesToAssign[i].toSend[j].parcel.name);
                            this.routesToAssign[i].toSend[j].setState(stateList[5]);
                        }
                        else if (this.routesToAssign[i].toSend[j].getState() != stateList[5]) {
                            done = false;
                        }
                    }
                }

                Thread.Sleep(5000);
            }


            Console.WriteLine("Company {0} ending operations", this.companyName);
        }
    }
}
