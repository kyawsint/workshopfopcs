using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex40
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                SQT(i);
            }
        }

        static void SQT(int num)
        {
            Console.WriteLine("{0:#.###}", Math.Sqrt(Convert.ToDouble(num)));
        }
    }
}
