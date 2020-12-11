using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421GUI
{
    public abstract class AbstractLoadableShippingObject : ShippingObjectIF
    {
        private Company enviroment;

        public void setEnviroment(Company company)
        {
            enviroment = company;
        }

        protected Company getEnviroment()
        {
            return enviroment;
        }

        public abstract string name { get; set; }

        public abstract string OnCreate();
    }
}
