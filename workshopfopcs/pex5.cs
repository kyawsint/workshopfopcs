using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex5
    {
        static void Main(string[] args)
        {
            // request a double number and print square root of that number with 3 decimal places
            Console.Write("Enter a double precision number : ");
            double num = Convert.ToDouble(Console.ReadLine());
            double num1 = Math.Sqrt(num);
            Console.WriteLine("{0:#.###} is the square root of that number with 3 decimal places {1}.",num1, num);
        }
    }
}
