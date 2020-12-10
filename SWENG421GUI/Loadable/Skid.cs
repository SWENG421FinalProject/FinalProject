﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421GUI.Loadable
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

        public override void OnCreate()
        {
            Console.WriteLine("Company: " + getEnviroment().companyName + " loaded and added Shipping Object of type: " + this.GetType().Name);
        }
    }
}
