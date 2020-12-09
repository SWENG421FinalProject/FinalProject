using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    class AbstractLoadableClass
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
    }
}
