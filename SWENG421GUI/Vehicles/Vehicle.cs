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
        public void VehicleThread(RichTextBox rtb, List<State> stateList) {
 
            //If there are no routes after 5 checks, then just quit
            //Works for a small number of threads, might not work for lots of threads, would need reference to
            //List of routes to assign and the company object
            int waits = 0;
            while (waits < 5) {

                //Check for a new route
                Console.WriteLine("{0} Checking if it has a route", this.identifier);
                
                //If a route is assigned start it
                if (this.todo != null)
                {
                    waits = 0;
                    Console.WriteLine("{0} is starting its route", this.identifier);
                    //Set all packages state to in transit
                    for (int i = 0; i < this.todo.toSend.Count; i++) {
                        this.todo.toSend[i].setState(stateList[3], this);
                    }

                    Random r = new Random();

                    //Wait a random amount of time between 1 and 5 seconds to travel to the 1st stop
                    int waitTime = r.Next(1000, 5000);
                    for (int i = 0; i < todo.toSend.Count; i++)
                    {
                        //Deliver package and wait 1-5 seconds and keep going

                        Console.WriteLine("{0}: Delivering package {1} to {2}", this.identifier, todo.toSend[i].trackingNumber, todo.toSend[i].destinationAddress);
                        Thread.Sleep(waitTime);
                        waitTime = r.Next(1000, 5000);
                        Console.WriteLine("{0}: Package {1} Delivered, setting its state to delivered", this.identifier, todo.toSend[i].trackingNumber);
                        todo.toSend[i].setState(stateList[4], this);
                    }

                    //Finsih route and restart
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
        public virtual void printInfo()
        {
            Console.WriteLine("Identifier: {0}\nLoad Count: {1}\nMPG: {2}", identifier, loadCount, mpg);
        }
    }
}
