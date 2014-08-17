using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer : ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:#.###} is the square root of that number {1}.", Math.Sqrt(num), num);
        }
    }
}
