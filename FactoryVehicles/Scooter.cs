using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicles
{
    internal class Scooter:Ivehicle
    {
        private int wheels;
        public Scooter()
        {
            this.wheels = 2;
        }

        public int numberOfvehicles()
        {
            return this.wheels;
        }

        public string vehicleType()
        {
            return "Scooter class.";
        }

    }
}
