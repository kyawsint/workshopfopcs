using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex29
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    a += i;   
                }
            }
            if (num == a)
            {
                Console.WriteLine("{0} is perfect number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not perfect number.", num);
            }
        }
    }
}
