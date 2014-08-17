using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter traveled distance : ");
            double num = Convert.ToDouble(Console.ReadLine());
            double total = Math.Ceiling(2.40 + num * 0.4);
            Console.WriteLine("Total fare is {0}.", total);
        }
    }
}
