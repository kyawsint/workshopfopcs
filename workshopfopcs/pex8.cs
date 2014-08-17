using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex8
    {
        static void Main(string[] args)
        { 
            // Convert temperature Centigrade to Fahrenheit
            Console.WriteLine("Enter temperature in Centigrade?");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in Fehrenheit {0}.", 1.8 * temp + 32);
        }
    }
}
