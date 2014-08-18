using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex36
    {
        static void Main(string[] args)
        {
            // check palidrome with phrase and string
            Console.Write("Enter a phrase to check palindrome : ");
            string str = Console.ReadLine();
            string pali = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                pali = pali + str[i];
            }
            if (str == pali)
            {
                Console.WriteLine("This phrase is a palindrome.");
            }
            else
            {
                Console.WriteLine("This phrase is not palindrome.");
            }

            Console.Write("Enter a string to check palindrome : ");
            string str1 = Console.ReadLine();
            str1 = str1.ToLower().Trim('.').Replace(" ", "");
            Console.WriteLine(str1);
            string palindrome = "";
            for (int j = str1.Length - 1; j >= 0; j--)
            {
                palindrome = palindrome + str1[j];
            }
            if (str1 == palindrome)
            {
                Console.WriteLine("This string is palindrome.");
            }
            else
                Console.WriteLine("This string is not palindrome.");
        }
    }
}
