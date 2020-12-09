using SWENG421GUI.States;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SWENG421GUI.Vehicles
{
    public abstract class Vehicle
    {
        public string identifier { get; set; }
        public int loadCount { get; set; }
        public double mpg { get; set; }
        public Route todo { get; set; }

        //Uses a RichTextBox to write output to
        public void VehicleThread(RichTextBox rtb) {
            int waits = 0;
            while (waits < 5) {
                Console.WriteLine("{0} Checking if it has a route", this.identifier);
                if (this.todo != null)
                {
                    waits = 0;
                    Console.WriteLine("{0} is starting its route", this.identifier);
                    //Console.WriteLine("Route Length = {0}", todo.toSend.Count);
                    Random r = new Random();
                    int waitTime = r.Next(1000, 5000);
                    for (int i = 0; i < todo.toSend.Count; i++)
                    {
                        Console.WriteLine("{0}: Delivering package {1} to {2}", this.identifier, todo.toSend[i].trackingNumber, todo.toSend[i].destinationAddress);
                        Thread.Sleep(waitTime);
                        waitTime = r.Next(1000, 5000);
                        Console.WriteLine("{0}: Package {1} Delivered, setting its state to delivered", this.identifier, todo.toSend[i].trackingNumber);
                        //todo.toSend[i].setState(new Delivered());
                    }
                    Console.WriteLine("{0} Finished delivering packages, returning to warehouse", this.identifier);
                    this.todo = null;
                    waitTime = r.Next(1000, 5000);
                    Thread.Sleep(waitTime);
                }
                else {
                    waits++;
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
