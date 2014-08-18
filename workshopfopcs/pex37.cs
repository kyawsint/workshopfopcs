using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex37
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            string title = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i != 0 && str[i - 1] == ' ' || i == 0)
                {
                    title = title + str[i].ToString().ToUpper();
                }
                else
                    title = title + str[i];
            }
            Console.WriteLine(title);
        }
    }
}
