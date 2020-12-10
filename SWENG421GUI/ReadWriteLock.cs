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

        public ReadWriteLock(string lName) {
            this.lockName = lName;
            this.locked = false;
            this.owner = null;
        }
        public void setLock(Object user) {
            bool finished = false;
            
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
                    finished = true;
                }
                else {
                    Console.WriteLine("Cannot give access of {0} to {1} object {2} because {3} of type {4} owns it", this.lockName, user.GetType(), user.ToString(), owner.ToString(), owner.GetType());
                    Console.WriteLine("Waiting until lock is available");
                    Thread.Sleep(r.Next(0, 1000));
                }
            }
        }
        public void freeLock(Object user) {
            if (!(locked)) {
                Console.WriteLine("A {0} object tried to free the lock {1} that is already unlocked", user.GetType(), this.lockName);
            }
            if (user.Equals(this.owner))
            {
                this.locked = false;
                this.owner = null;
                Console.WriteLine("{0} was freed", this.lockName);
            }
            else {
                Console.WriteLine("{0} does not equal {1} and cannot free the lock {2}", user.ToString(), this.owner.ToString(), this.lockName);
            }
        }
    }
}
