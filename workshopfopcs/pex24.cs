using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex24
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int g, rdmno;
            double sqrtno;
            Random rdm = new Random();
            sqrtno = Math.Round(Math.Sqrt(num));
            if (Math.Pow(sqrtno, 2) == num)
            {
                Console.WriteLine("{0} is square root of this number {1}.", sqrtno, num);
            }
            else
            {
                Console.WriteLine("{0} is can't square root.", num);
            }

            do
            {
                rdmno = rdm.Next(0, num);
                Console.Write("Enter guess number : ");
                g = Convert.ToInt32(Console.ReadLine());
            } while (rdmno != g && Math.Pow(g, 2) == num);
            Console.WriteLine("Lucky . . . ");

            //// b
            //do
            //{
            //    rdmno = rdm.Next(0, num);
            //    Console.Write("Enter number for guess : ");
            //    g = Convert.ToInt32(Console.ReadLine());
            //} while (rdmno != g);
            //Console.WriteLine("Lucky . . . ");

            //// c
            //do
            //{
            //    rdmno = rdm.Next(0, num);
            //    Console.WriteLine("Enter guess number which is the square root of this number {0}.", num);
            //    g = Convert.ToInt32(Console.ReadLine());
            //} while (num != Math.Pow(g, 2));
            //Console.WriteLine("{0} is square root of this number {1}.", g, num);
        }
    }
}
