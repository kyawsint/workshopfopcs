using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex21
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter an integer : ");
                num= Convert.ToInt32(Console.ReadLine());
            } while (num != 88);
            Console.WriteLine("Lucky you . . . ");
        }
    }
}
