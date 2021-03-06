﻿using SWENG421GUI.States;
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
        private List<Vehicle> vehicles;
        private List<Route> routesToAssign;
        private List<Order> ordersToAssign;
        private List<ShippingObjectIF> parcelsToAssign;
        private string companyName;
        private bool running = false;

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
        public void setRoutesToAssign(List<Route> routesToAssign)
        {
            this.routesToAssign = routesToAssign;
        }
        public List<Route> getRoutesToAssign()
        {
            return this.routesToAssign;
        }
        public List<Order> getOrdersToAssign()
        {
            return this.ordersToAssign;
        }
        public void setOrdersToAssign(List<Order> orders)
        {
            this.ordersToAssign = orders;
        }
        public void setParcelsToAssign(List<ShippingObjectIF> parcels)
        {
            this.parcelsToAssign = parcels;
        }
        public List<ShippingObjectIF> getParcelsToAssign()
        {
            return this.parcelsToAssign;
        }
        public void setCompanyName(string cn)
        {
            this.companyName = cn;
        }
        public string getCompanyName()
        {
            return this.companyName;
        }
        public void setRunning(bool running)
        {
            this.running = running;
        }
        public bool getRunning()
        {
            return this.running;
        }

        // company tells factory to make and return a vehicle
        public Vehicle addVehicle(string type)
        {
            VehicleFactory factory = new VehicleFactory();
            Vehicle v;
            Type t = Type.GetType(type);
            if (t.IsSubclassOf(typeof(AbstractLoadableVehicle)))
            {
                AbstractLoadableVehicle loadableVehicle;
                loadableVehicle = (AbstractLoadableVehicle)Activator.CreateInstance(t);
                loadableVehicle.setEnviroment(this);
                v = loadableVehicle;
            }
            else { 
                v = factory.createVehicle(type);
            }
            vehicles.Add(v);
            return v;
        }

        public ShippingObjectIF addParcel(string type)
        {
            Type t = Type.GetType(type);
            ShippingObjectIF obj;
            if (t.IsSubclassOf(typeof(AbstractLoadableShippingObject)))
            {
                obj = addLoadableParcel(t.FullName);
                parcelsToAssign.Add(obj);
            }
            else
            {
                obj = (ShippingObjectIF)Activator.CreateInstance(t, t.Name);
                parcelsToAssign.Add(obj);
            }
            return obj;
        }
        public ShippingObjectIF addPallet(string type, string palletableName, string palletName)
        {
            ShippingObjectIF obj;
            Type t = Type.GetType(type);
            PalletableIF palletable = (PalletableIF)Activator.CreateInstance(t, palletableName);
            obj = new Pallet(palletName, palletable);
            parcelsToAssign.Add(obj);
            return obj;
        }
        public ShippingObjectIF addLoadableParcel(string type)
        {
            ShippingObjectIF shippingObject;
            Type t = Type.GetType(type);
            AbstractLoadableShippingObject loadableShippingObject;
            loadableShippingObject = (AbstractLoadableShippingObject)Activator.CreateInstance(t, t.ToString());
            loadableShippingObject.setEnviroment(this);
            shippingObject = loadableShippingObject;
            parcelsToAssign.Add(shippingObject);
            return shippingObject;
        }

        //Uses a RichTextBox to write output to
        public void CompanyThread(Form1 f1, List<State> stateList)
        {
            running = true;
            string toAdd = "";
            //Use variable rather than removing routes from list
            int routesLeft = routesToAssign.Count;

            //Write output to textbox instead of the console
            //Console.WriteLine("Company {0} starting operations", this.companyName);
            toAdd = "Company " + this.companyName + " starting operations\n";
            f1.updateOutputPanel(toAdd);

            //Keep running until all routes are assigned
            while (routesLeft > 0 && vehicles.Count != 0) {
                //Console.WriteLine("Have {0} routes to assign\nChecking {1} vehicles to see if they are ready for a new route", this.routesToAssign.Count, this.vehicles.Count);
                toAdd = "Have " + this.routesToAssign.Count + " routes to assign\nChecking " + this.vehicles.Count + " vehicles to see if they are ready for a new route\n";
                f1.updateOutputPanel(toAdd);

                //Check all vehicles to see if any are ready for a new route
                for (int i = 0; i < vehicles.Count; i++) {
                    for (int j = 0; j < this.routesToAssign.Count; j++) {
                        if (routesToAssign[j].assigned == false)
                        {
                            //If a vehicle doesn't have a route, assign it one
                            if (vehicles[i].todo == null && routesLeft > 0)
                            {
                                //Console.WriteLine("Adding route to {0}", vehicles[i].identifier);
                                toAdd = "Adding route to " + vehicles[i].identifier + "\n";
                                f1.updateOutputPanel(toAdd);

                                //Assign route
                                vehicles[i].setRoute(routesToAssign[j]);
                                routesToAssign[j].assigned = true;
                                for (int x = 0; x < routesToAssign[j].toSend.Count; x++)
                                {
                                    routesToAssign[j].toSend[x].setState(stateList[2], this);
                                }
                                //Remove route from list
                                //this.routesToAssign.RemoveAt(0);
                                routesLeft--;
                            }
                            //Else print out a message if there are still routes to assign
                            else if (routesLeft > 0)
                            {
                                //Console.WriteLine("Vehicle {0} already has a route", vehicles[i].identifier);
                                toAdd = "Vehicle " + vehicles[i].identifier + " already has a route\n";
                                f1.updateOutputPanel(toAdd);
                            }
                        }
                    } 
                }

                //Print message at end of loop
                //Console.WriteLine("Company {0} Finished Checking Vehicles", this.companyName);
                toAdd = "Company " + this.companyName + " Finished Checking Vehicles\n";
                f1.updateOutputPanel(toAdd);

                //Wait if there are still routes to assign
                if (routesLeft > 0) {
                    //Console.WriteLine("Company {0} has {1} Route(s) to assign", this.companyName, this.routesToAssign.Count);
                    toAdd = "Company " + this.companyName + " has " + this.routesToAssign.Count + " Routes(s) to assign\n";
                    f1.updateOutputPanel(toAdd);

                    Thread.Sleep(8000);
                }
            }

            //Loop finished
            //Console.WriteLine("Company {0} assigned all its routes. Confirming packages were delivered", this.companyName);
            toAdd = "All routes assigned. Company " + this.companyName + " ending operations\n";
            f1.updateOutputPanel(toAdd);

            bool done = false;
            while (!(done)){
                done = true;
                //Console.WriteLine("Company {0} checking in packages", this.companyName);
                toAdd = "Company " + this.companyName + " checking in packages\n";
                f1.updateOutputPanel(toAdd);

                for (int i = 0; i < this.routesToAssign.Count; i++) {
                    for (int j = 0; j < this.routesToAssign[i].toSend.Count; j++) {
                        toAdd = "Company " + this.companyName + " looking at package: " + this.routesToAssign[i].toSend[j].parcel.name + " State = " + this.routesToAssign[i].toSend[j].getState(this).getStateName() + "\n";
                        f1.updateOutputPanel(toAdd);

                        if (this.routesToAssign[i].toSend[j].getState(this) == stateList[4])
                        {
                            //Console.WriteLine("Company {0} Checking in package {1}", this.companyName, this.routesToAssign[i].toSend[j].parcel.name);
                            toAdd = "Company " + this.companyName + " Checking in package " + this.routesToAssign[i].toSend[j].parcel.name + "\n";
                            f1.updateOutputPanel(toAdd);

                            this.routesToAssign[i].toSend[j].setState(stateList[5], this);
                        }
                        else if (this.routesToAssign[i].toSend[j].getState(this) != stateList[5]) {
                            done = false;
                        }
                    }
                }

                Thread.Sleep(9000);
            }


            //Console.WriteLine("Company {0} ending operations", this.companyName);
            toAdd = "Company " + this.companyName + " ending operations\n";
            f1.updateOutputPanel(toAdd);
            running = false;
        }
    }
}
