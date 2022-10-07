using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicles
{
    internal class vehicles
    {
        public static Ivehicle getVehicles(string type)
        {
            Ivehicle objType = null;
            if (type.ToLower().Equals("bike"))
            {
                objType = new Bike();
            }
            else if (type.ToLower().Equals("car"))
            {
                objType = new Car();
            }
            else if (type.ToLower().Equals("scooter"))
            {
                objType = new Scooter();
            }
            return objType;

        }

    }
}
