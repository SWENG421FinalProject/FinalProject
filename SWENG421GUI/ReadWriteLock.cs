using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class ReadWriteLock
    {
        private string lockName;
        private bool locked;
        private Object owner;

        public ReadWriteLock(string lName) {
            this.lockName = lName;
            this.locked = false;
            this.owner = null;
        }
        public void setLock(Object user) {
            if (!(locked))
            {
                this.locked = true;
                this.owner = user;
                Console.WriteLine("A {0} object just set the lock {1} and became the owner", user.GetType(), this.lockName);
            }
            else {
                Console.WriteLine("Cannot give access of {0} to {1} object {2} because {3} of type {4} owns it", this.lockName, user.GetType(), user.ToString(), owner.ToString(), owner.GetType());
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
