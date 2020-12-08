using SWENG421FinalProject.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Order
    {
        public string trackingNumber;
        public string originAddress;
        public string destinationAddress;
        public string senderName;
        public string receiverName;
        public ShippingObjectIF parcel;
        private State currentState;
        private ReadWriteLock myLock;

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
        public State getState() {
            return this.currentState;
        }
        public void setState(State s) {
            this.currentState = s;
        }
    }
}
