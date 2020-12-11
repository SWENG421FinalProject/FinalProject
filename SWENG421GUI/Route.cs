using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public class Route
    {
        public string name { get; set; }
        public bool assigned { get; set; }
        public List<Order> toSend { get; set; }

        public Route(string n) {
            this.name = n;
            this.assigned = false;
            this.toSend = new List<Order>();
        }
    }
}
