using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SWENG421GUI
{
    public class ReadWriteLock
    {
        private string lockName;
        private bool locked;
        private Object owner;
        public Random r = new Random();
        
        //Form used to access ouptut panel
        public Form1 f1;
        //f1.updateOutputPanel() prints message to panel
        //Commented out lock messages because there are too many
        //They just print to the console right now
        public ReadWriteLock(string lName, Form1 f) {
            this.lockName = lName;
            this.locked = false;
            this.owner = null;
            this.f1 = f;
        }
        public void setLock(Object user) {
            bool finished = false;
            string toAdd = "";
            //Try to get the lock, if it doesn't work wait a random amount of time and try again
            while (!(finished)) {
                if (!(locked))
                {
                    this.locked = true;
                    this.owner = user;
                    string userName;
                    if (user.GetType().ToString() == "SWENG421GUI.Company")
                    {
                        userName = ((Company)user).companyName;
                    }
                    else if (user.GetType().ToString().Contains("SWENG421GUI.Vehicles")) {
                        userName = ((Vehicle)user).identifier;
                    }
                    else{
                        userName = user.GetType().ToString();
                    }
                    Console.WriteLine("{0} just set the lock {1} and became the owner", userName, this.lockName);
                    toAdd = userName + " just set the lock " + this.lockName + " and became the owner\n";
                    //f1.updateOutputPanel(toAdd);

                    finished = true;
                }
                else {
                    Console.WriteLine("Cannot give access of {0} to {1} object {2} because {3} of type {4} owns it", this.lockName, user.GetType(), user.ToString(), owner.ToString(), owner.GetType());
                    toAdd = "Cannot give access of " + this.lockName + " to " + user.GetType() + " object " + user.ToString() + " because " + owner.ToString() + " of type " + owner.GetType() + " owns it\n";
                    //f1.updateOutputPanel(toAdd);

                    Console.WriteLine("Waiting until lock is available");
                    toAdd = "Waiting until lock is available\n";
                    //f1.updateOutputPanel(toAdd);

                    Thread.Sleep(r.Next(0, 1000));
                }
            }
        }
        public void freeLock(Object user) {
            string toAdd = "";
            if (!(locked)) {
                Console.WriteLine("A {0} object tried to free the lock {1} that is already unlocked", user.GetType(), this.lockName);
                toAdd = " A " + user.GetType() +" object tried to free the lock " + this.lockName +" that is already unlocked\n";
                //f1.updateOutputPanel(toAdd);
            }
            if (user.Equals(this.owner))
            {
                this.locked = false;
                this.owner = null;
                Console.WriteLine("{0} was freed", this.lockName);
                toAdd = this.lockName + " was freed\n";
                //f1.updateOutputPanel(toAdd);
            }
            else {
                Console.WriteLine("{0} does not equal {1} and cannot free the lock {2}", user.ToString(), this.owner.ToString(), this.lockName);
                toAdd = user.ToString() + " does not equal " + this.owner.ToString() + " and cannot free the lock " + this.lockName + "\n";
                //f1.updateOutputPanel(toAdd);
            }
        }
    }
}
