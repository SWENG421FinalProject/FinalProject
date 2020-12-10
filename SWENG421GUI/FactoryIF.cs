using SWENG421GUI.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421GUI
{
    public interface FactoryIF
    {
        Vehicle createVehicle(string type);
    }
}
