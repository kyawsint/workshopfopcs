using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex42
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string S1 : ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string S2 : ");
            string s2 = Console.ReadLine();
            int compare= FindWord(s1, s2);
            Console.WriteLine(compare);
        }

        static int FindWord(string s1, string s2)
        {
            return string.Compare(s1, s2);
            //return s1.CompareTo(s2);
        }
    }
}
