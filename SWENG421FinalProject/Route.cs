using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Route
    {
        public bool assigned;
        public List<Order> toSend;

        public Route() {
            this.assigned = false;
            this.toSend = new List<Order>();
        }
    }
}
