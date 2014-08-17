using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex25
    {
        static void Main(string[] args)
        {
            // Factorial
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a=1;
            for (int i = num; i >= 1; i--)
            {
                a = a * i;
            }
            Console.WriteLine("{0} factorial is {1}.", num, a);
        }
    }
}
