using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex22
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = getvalue("A");
            b = getvalue("B");
            if (a > b)
            {
                do
                {
                    c = a - b;
                } while (a == b);
                Console.WriteLine("A and B are equals with this number {0}.", c);
                Console.WriteLine("LCM values is : {0}.", (a * b) / c);
            }
            else
            {
                do
                {
                    c = b - a;
                } while (b == a);
                Console.WriteLine("B and A are equals with this number {0}.", c);
                Console.WriteLine("LCM values is : {0}.", (a * b) / c);
            }
        }

        static int getvalue(string str)
        {
            Console.Write("Enter number {0} : ", str);
            return (Convert.ToInt32(Console.ReadLine()));
        }
    }
}
