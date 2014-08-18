using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex30
    {
        static void Main(string[] args)
        {
            for (int pri = 5; pri <= 10000; pri++)
            {
                Boolean flag = isprime(pri);
                if (flag)
                {
                    Console.WriteLine("{0} is prime number.", pri);
                }
            }
        }

        static bool isprime(int pri)
        {
            for (int i = 2; i <= pri; i++)
            {
                if (pri % i == 0 && pri != i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
