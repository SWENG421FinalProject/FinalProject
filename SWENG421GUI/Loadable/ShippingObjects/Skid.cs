using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421GUI.Loadable.ShippingObjects
{
    public class Skid : AbstractLoadableShippingObject
    {
        public string Name;

        public Skid(string n)
        {
            this.Name = n;
        }

        //Used by GUI
        public override string name
        {
            get { return Name; }
            set { this.Name = value; }
        }

        public override string OnCreate()
        {
            return("Company: " + getEnviroment().companyName + " loaded and added Shipping Object of type: " + this.GetType().Name);
        }
    }
}
