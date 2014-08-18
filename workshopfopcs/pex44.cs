using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex44
    {
        static void Main(string[] args)
        {
            char c1, c2;
            Console.Write("Enter string S : ");
            string s = Console.ReadLine();
            Console.Write("Enter Char C1 : ");
            c1 = char.Parse(Console.ReadLine());
            Console.Write("Enter Char C2 : ");
            c2 = char.Parse(Console.ReadLine());
            //string s = "Institute";
            //char c1 = 's';
            //char c2 = '$';
            string newword = "";
            newword = Substitute(s, c1, c2);
            Console.WriteLine(newword);
        }

        static string Substitute(string s, char c1, char c2)
        {
            string newword = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (c1 == s[i])
                {
                    newword = s.Replace(c1, c2);
                }
            }
            return newword;
        }
    }
}
