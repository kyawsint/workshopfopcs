using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex43
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter number : ");
            int i = Convert.ToInt32(Console.ReadLine());
            string hexval = i.ToString("X");
            int str = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(str);
            //double d= Convert.ToDouble(Console.ReadLine());
            //string str = toHex(d);
            //Console.WriteLine(str);
        }

        static string toHex(double d)
        {
            var r=d%16;
            string result = "";
            Console.WriteLine(r);
            if (d - r == 0)
                result = Convert.ToString(r);
            else
                result = toHex((d - r) / 16) + Convert.ToString(r);
            return result;
        }
    }
}
