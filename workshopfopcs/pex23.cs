using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex23
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int rdmno, num, i = 1;
            do
            {
                rdmno = rdm.Next(0, 9);
                Console.Write("Enter number within 0 to 9 : ");
                num = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (rdmno != num);
            if (i < 3)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (i > 2 && i <= 5)
            {
                Console.WriteLine("You are a good guess!");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }
        }
    }
}
