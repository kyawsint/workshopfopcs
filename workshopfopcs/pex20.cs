using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex20
    {
        static void Main(string[] args)
        {
            // request product code and quantity and print discount for that products
            string pcode;
            int qty, price, total;
            Console.Write("Enter product code : ");
            pcode = Console.ReadLine();
            Console.Write("Enter product quantity : ");
            qty = Convert.ToInt32(Console.ReadLine());
            if (pcode == "TV")
            {
                price = qty * 900;
            }
            else if (pcode == "DVD")
            {
                price = qty * 500;
            }
            else if (pcode == "MP3")
            {
                price = qty * 700;
            }
            else
            {
                price = 0;
            }

            if (pcode == "TV" || pcode == "DVD")
            {
                if (price >= 10000)
                {
                    total = price - price * 15 / 100;
                    Console.WriteLine("The total prices is {0}.", total);
                }
                else if (price >= 5000)
                {
                    total = price - price * 10 / 100;
                    Console.WriteLine("The total prices is {0}.", total);
                }
                else
                {
                    total = price;
                    Console.WriteLine("The total price is {0}.", total);
                }
            }
            else
            {
                total = price;
                Console.WriteLine("The total price is {0}.", total);
            }
            
            
            //string[] str = Console.ReadLine().Split(',');
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
        }
    }
}
