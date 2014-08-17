using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex14
    {
        static void Main(string[] args)
        {
            double a, b, c, s, area;
            a = getlength("A");
            b = getlength("B");
            c = getlength("C");
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("The area is {0}.", area);
        }

        static double getlength(string str)
        {
            Console.Write("Enter Length of {0} : ", str);
            return (Convert.ToDouble(Console.ReadLine()));
        }
    }
}
