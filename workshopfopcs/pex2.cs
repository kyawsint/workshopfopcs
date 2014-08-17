using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex2
    {
        static void Main(string[] args)
        {
            // request an integer and print the square of that number
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is the square of that number {1}.", num * num, num);
        }
    }
}
