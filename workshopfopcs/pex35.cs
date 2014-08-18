using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phrase?");
            string str = Console.ReadLine();
            int a = 0, e = 0, i = 0, o = 0, u = 0, total = 0;
            char[] vol = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j].Equals('a'))
                {
                    a += 1;
                }
                else if (str[j].Equals('e'))
                {
                    e += 1;
                }
                else if (str[j].Equals('i'))
                {
                    i += 1;
                }
                else if (str[j].Equals('o'))
                {
                    o += 1;
                }
                else if (str[j].Equals('u'))
                {
                    u += 1;
                }
                if (vol.Contains(str[j]))
                {
                    total += 1;
                }
                
            }
            Console.WriteLine("Number of vowel a : {0}.", a);
            Console.WriteLine("Number of vowel e : {0}.", e);
            Console.WriteLine("Number of vowel i : {0}.", i);
            Console.WriteLine("Number of vowel o : {0}.", o);
            Console.WriteLine("Number of vowel u : {0}.", u);
            Console.WriteLine("Total number of vowels : {0}.", total);
        }
    }
}
