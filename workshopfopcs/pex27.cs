using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex27
    {
        static void Main(string[] args)
        {
            double y;
            for (double x = -10; x <= 10; x++)
            {
                y = 5 * Math.Pow(x, 2) - 4 * x + 3;
                if (x >= 1 && x <= 20)
                {
                    Console.WriteLine("The value of y : {0} *.", y);
                }
                else
                {
                    Console.WriteLine("The value of y : {0}.", y);
                }
            }
        }
    }
}
