using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a double precision number : ");
            double num = Convert.ToDouble(Console.ReadLine());
            double num1 = Math.Sqrt(num);
            Console.WriteLine("{0} is the square root of that number {1}.", num1, num);
        }
    }
}
