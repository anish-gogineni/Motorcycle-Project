using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle_Project
{
    internal class Wheel
    {
        public static string diameter;
        public static string tyretype;

        // default constructor
        public Wheel()
        {
            diameter = "15 inches ";
            tyretype = " tubeless ";
        }


        public void rotate()
        {
            Console.WriteLine(" rotating wheels ");
        }


    }
}
