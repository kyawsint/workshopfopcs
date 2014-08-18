using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex39
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to calculate factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string fac = factorial(num);
            Console.WriteLine(fac);
        }

        static string factorial(int num)
        {
            string str = "";
            int fac = 1;
            for (int i = num; i >= 1; i--)
            {
                str = str + i;
                fac = fac * i;
                if (i != 1)
                    str = str + "x";
            }
            return str + "=" + fac;
        }
    }
}
