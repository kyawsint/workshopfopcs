using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex45
    {
        static void Main(string[] args)
        {
            int cents100 = 0, cents50 = 0, cents20 = 0, cents10 = 0, cents5 = 0;
            Console.Write("Enter amount : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            amt=amt*100;
            do { if (amt >= 100) { amt = amt - 100; cents100 += 1; } } while (amt >= 100);
            do { if (amt >= 50) { amt = amt - 50; cents50 += 1; } } while (amt >= 50);
            do { if (amt >= 20) { amt = amt - 20; cents20 += 1; } } while (amt >= 20);
            do { if (amt >= 10) { amt = amt - 10; cents10 += 1; } } while (amt >= 10);
            do { if (amt >= 5) { amt = amt - 5; cents5 += 1; } } while (amt >= 5);
            if (amt != 0)
            {
                Console.WriteLine("Not accurately amount! Please enter at least 5 cents!");
            }
            else
            {
                Console.WriteLine("100-cent : {0} coins.", cents100);
                Console.WriteLine("50-cent : {0} coins.", cents50);
                Console.WriteLine("20-cent : {0} coins.", cents20);
                Console.WriteLine("10-cent : {0} coins.", cents10);
                Console.WriteLine("5-cent : {0} coins.", cents5);
            }
        }
    }
}
