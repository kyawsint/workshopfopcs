using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter traveled distance : ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total fare is {0}.", (2.40 + num * 0.4));
        }
    }
}
