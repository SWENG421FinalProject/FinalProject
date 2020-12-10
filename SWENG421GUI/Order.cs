using SWENG421GUI.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class Order : OrderIF
    {
        public string trackingNumber { get; set; }
        public string originAddress { get; set; }
        public string destinationAddress { get; set; }
        public string senderName { get; set; }
        public string receiverName { get; set; }
        public ShippingObjectIF parcel { get; set; }
        private State currentState { get; set; }
        private ReadWriteLock myLock { get; set; }

        public Order() {
            this.trackingNumber = "";
            this.originAddress = "";
            this.destinationAddress = "";
            this.senderName = "";
            this.receiverName = "";
            this.parcel = null;
            this.currentState = new NeedRoute();
            this.myLock = new ReadWriteLock("New Order Lock");
        }
        public Order(string trackNum, string originAddr, string destAddr, string sendName, string receiveName, ShippingObjectIF p, State curState, ReadWriteLock rwl) {
            this.trackingNumber = trackNum;
            this.originAddress = originAddr;
            this.destinationAddress = destAddr;
            this.senderName = sendName;
            this.receiverName = receiveName;
            this.parcel = p;
            this.currentState = curState;
            this.myLock = rwl;
        }
        public Order(string trackNum, string originAddr, string destAddr, string sendName, string receiveName, ShippingObjectIF p)
        {
            this.trackingNumber = trackNum;
            this.originAddress = originAddr;
            this.destinationAddress = destAddr;
            this.senderName = sendName;
            this.receiverName = receiveName;
            this.parcel = p;
            this.currentState = new NeedRoute();
            this.myLock = new ReadWriteLock("Object " + trackNum + " Lock");
        }
        public ReadWriteLock getLock() {
            return this.myLock;
        }
        public void setLock(ReadWriteLock rwl) {
            this.myLock = rwl;
        }

        //State reads and writes lock and unlock the read/write lock so that other threads
        //have to wait until the current lock owner is done with their read or write operation
        public State getState(Object user) {
            this.myLock.setLock(user);
            State ans = this.currentState;
            this.myLock.freeLock(user);
            return ans;
        }
        public void setState(State s, Object user) {
            this.myLock.setLock(user);
            this.currentState = s;
            this.myLock.freeLock(user);
        }
    }
}
