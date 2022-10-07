using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicles
{
    internal class Car : Ivehicle
    {
        private int wheels;

        public Car()
        {
            this.wheels = 4;
        }

        public int numberOfvehicles()
        {
            return this.wheels;
        }

        public string vehicleType()
        {
            return "Car class.";
        }
    }
}
