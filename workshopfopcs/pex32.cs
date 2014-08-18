using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex32
    {
        static void Main(string[] args)
        {
            int[] sales = new int[] { 12, 34, 44, 66, 33, 54, 34, 67, 24, 23, 21, 49 };
            int total=0,avg=0;
            int min = sales[0], max = sales[0];
            for (int i = 0; i < sales.Length; i++)
            {
                total+=sales[i];
                Console.WriteLine("Sales for 12 months : {0}.", sales[i]);
                if (sales[i] < min)
                {
                    min = sales[i];
                }
                else if (sales[i] > max)
                {
                    max = sales[i];
                }
            }
            avg=total/sales.Length;
            Console.WriteLine("The month when maximum sales is recorded {0}.", max);
            Console.WriteLine("The month when minimum sales is recorded {0}.", min);
            Console.WriteLine("The average monthly sales for the year {0}.", avg);
        }
    }
}
