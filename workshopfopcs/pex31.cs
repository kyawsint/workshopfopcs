using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex31
    {
        static void Main(string[] args)
        {
            for (int per = 1; per <= 1000; per++)
            {
                int a = 0;
                for (int i = 1; i < per; i++)
                {
                    if (per % i == 0)
                    {
                        a += i;
                    }
                }
                if (per == a)
                {
                    Console.WriteLine("{0} is perfect number.", per);
                }
            }
        }
    }
}
