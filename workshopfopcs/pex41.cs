using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex41
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string S1 : ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string s2 : ");
            string s2 = Console.ReadLine();
            bool flag = InString(s1, s2);
            if (flag)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }

        static bool InString(string s1, string s2)
        {

            if (s2.Contains(s1))
            {
                return true;
            }
            else return false;
        }
    }
}
