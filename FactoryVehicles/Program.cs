using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryVehicles.Ivehicle;

namespace FactoryVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            Console.WriteLine("Enter the Vehicle Type..");
            input = Console.ReadLine();
            Ivehicle Type = vehicles.getVehicles(input);
            Console.WriteLine("Type is: " + Type.vehicleType());
            Console.WriteLine("Number of Wheel is: " + Type.numberOfvehicles());

            Console.ReadLine();
        }
    }
}
