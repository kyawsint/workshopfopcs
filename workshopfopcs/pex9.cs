using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of X : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of Y : {0}.", 5 * x * x - 4 * x + 3);
        }
    }
}
