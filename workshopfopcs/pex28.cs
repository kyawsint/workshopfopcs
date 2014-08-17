using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex28
    {
        static void Main(string[] args)
        {
            // prime or not prime
            Console.Write("Enter number : ");
            int pri = Convert.ToInt32(Console.ReadLine());
            Boolean flag = isprime(pri);
            if (flag)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
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
