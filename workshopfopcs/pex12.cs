using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter traveled distance : ");
            double num = Convert.ToDouble(Console.ReadLine());
            double total = Math.Round((2.40 + num * 0.4), 1);
            Console.WriteLine("Total fare is {0}.", total);
        }
    }
}
