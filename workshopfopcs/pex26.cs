using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex26
    {
        static void Main(string[] args)
        {
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t{1:###.###}\t{2:###.###}\t{3}", i, 1 / i, Math.Sqrt(i), Math.Pow(i, 2));
            }
        }
    }
}
