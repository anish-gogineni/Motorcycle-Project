using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle_Project
{
    internal class Engine
    {
        public static string type;
        public static string fueltype;
        public static string displacement;

        public void Ignite()
        {
            Console.WriteLine("Iginitation starts");
        }

        // Default Constructor
        public Engine()
        {
            type = "V - twin";
            fueltype = "Gasoline";
            displacement = "500CC";

        }

      
    }
}
