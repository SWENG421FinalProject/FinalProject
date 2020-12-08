using System;
using System.Collections.Generic;
using System.Text;

namespace SWENG421FinalProject.States
{
    public abstract class State
    {
        private string stateName;
        public string getStateName() {
            return stateName;
        }
        public void setStateName(string name) {
            this.stateName = name;
        }
    }
}
