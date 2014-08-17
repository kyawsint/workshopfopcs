using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex3
    {
        static void Main(string[] args)
        { 
            // request double precision number and print the square of that number
            Console.Write("Enter a double precision number : ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} is square of that number {1}.", num * num, num);
        }
    }
}
