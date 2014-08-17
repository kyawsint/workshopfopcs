using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex19
    {
        static void Main(string[] args)
        {
            // request kilometers and print total charges
            Console.Write("Enter you travelled kilometer : ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double total = 0;
            if (kilo <= 0.5)
            {
                total = 2.40;
            }
            else if (kilo >= 0.5 && kilo <= 9)
            {
                total = 2.40 + (kilo - 0.5) * 10 * 0.04;
            }
            else if (kilo > 9)
            {
                total = 2.40 + ((kilo - 0.5) * 10 * 0.04) + ((kilo - 9) * 10 * 0.05);
            }
            else
            {
                total = 0;
            }
            Console.WriteLine("Total charge is {0}.", Math.Round(total, 1));
        }
    }
}
