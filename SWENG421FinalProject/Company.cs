using SWENG421FinalProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject
{
    public class Company
    {
        private List<Vehicle> vehicles;
        public string companyName;
        public Company(string name) {
            this.companyName = name;
            vehicles = new List<Vehicle>();
        }
        public Company(string name, List<Vehicle> vs) {
            this.companyName = name;
            this.vehicles = vs;
        }
        public List<Vehicle> getVehicles() {
            return this.vehicles;
        }
        public void setVehicles(List<Vehicle> vs) {
            this.vehicles = vs;
        }

        public void CompanyThread()
        {

        }
    }
}
