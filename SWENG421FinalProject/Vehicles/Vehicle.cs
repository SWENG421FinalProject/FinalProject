using SWENG421FinalProject.States;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SWENG421FinalProject.Vehicles
{
    public abstract class Vehicle
    {
        public string identifier;
        public int loadCount;
        public double mpg;
        public Route todo;

        public void VehicleThread() {
            while (true) {
                Console.WriteLine("{0} Checking if it has a route", this.identifier);
                if (this.todo != null)
                {
                    Console.WriteLine("{0} is starting its route", this.identifier);
                    Console.WriteLine("Route Length = {0}", todo.toSend.Count);
                    Random r = new Random();
                    int waitTime = r.Next(1000, 5000);
                    for (int i = 0; i < todo.toSend.Count; i++)
                    {
                        Console.WriteLine("Delivering package {0} to {1}", todo.toSend[i].trackingNumber, todo.toSend[i].destinationAddress);
                        Thread.Sleep(waitTime);
                        waitTime = r.Next(1000, 5000);
                        Console.WriteLine("Package {0} Delivered, setting its state to delivered", todo.toSend[i].trackingNumber);
                        //todo.toSend[i].setState(new Delivered());
                    }
                    Console.WriteLine("Finished delivering packages, returning to warehouse");
                    this.todo = null;
                    waitTime = r.Next(1000, 5000);
                    Thread.Sleep(waitTime);
                }
                else {
                    Thread.Sleep(5000);
                }
            }
        }
        public Route getRoute() {
            return this.todo;
        }
        public void setRoute(Route td) {
            if (td.toSend.Count > loadCount)
            {
                Console.WriteLine("CANNOT ASSIGN ROUTE: ROUTE LENGTH > LOAD COUNT");
            }
            else {
                this.todo = td;
            }
        }
    }
}
