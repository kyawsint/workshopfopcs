using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex7
    {
        static void Main(string[] args)
        { 
            // salary with allowance
            Console.WriteLine("Enter your salary?");
            int sal = Convert.ToInt32(Console.ReadLine());
            int total = sal + sal * 10 / 100 + sal * 3 / 100;
            Console.WriteLine("Total income is {0}.", total);
        }
    }
}
