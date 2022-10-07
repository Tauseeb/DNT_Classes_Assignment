using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicles
{
    internal class Bike:Ivehicle
    {
        private int wheels;
        public Bike()
        {
            this.wheels = 2;
        }

        public int numberOfvehicles()
        {
            return this.wheels;
        }

        public string vehicleType()
        {
            return "Bike class.";
        }


    }
}
