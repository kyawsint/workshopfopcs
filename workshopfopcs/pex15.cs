using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex15
    {
        static void Main(string[] args)
        {
            int armno, temp, remainder, sum = 0;
            Console.Write("Enter an integer : ");
            armno = Convert.ToInt32(Console.ReadLine());
            temp = armno;
            while (temp != 0)
            {
                remainder = temp % 10;
                sum = sum + remainder * remainder * remainder;
                temp = temp / 10;
            }

            //for (int i = armno; i > 0; i = i / 10)
            //{
            //    remainder = i % 10;
            //    sum = sum + remainder * remainder * remainder;
            //}
            if (sum == armno)
            {
                Console.WriteLine("This number is armstrong number.");
            }
            else
            {
                Console.WriteLine("This number is not armstrong number.");
            }
        }
    }
}
