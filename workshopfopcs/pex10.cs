using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex10
    {
        static void Main(string[] args)
        {
            // the distance between the two points
            int x1, x2, y1, y2;
            x1 = entervalue("X1");
            x2 = entervalue("X2");
            y1 = entervalue("Y1");
            y2 = entervalue("Y2");
            double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The distance is {0}.", dist);
        }

        static int entervalue(string str)
        {
            Console.WriteLine("Enter number " + str + " ?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
