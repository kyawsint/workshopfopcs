using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex38
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            for (int i = 0; i < mark.Length; i++)
            {
                for (int j = 0; j < mark.Length; j++)
                {
                    if (mark[i] > mark[j])
                    {
                        string tempname = name[i];
                        name[i] = name[j];
                        name[j] = tempname;
                        int tempmark = mark[i];
                        mark[i] = mark[j];
                        mark[j] = tempmark;
                    }
                }
            }

            Console.WriteLine("Sorted by descending order of the marks.");
            for (int a = 0; a < mark.Length; a++)
            {
                Console.WriteLine("{0}\t{1}", mark[a], name[a]);
            }
            Console.WriteLine();

            for (int b = 0; b < name.Length; b++)
            {
                for (int c = 0; c < name.Length; c++)
                {
                    if (name[b].CompareTo(name[c]) < 0)
                    {
                        string tempname1 = name[b];
                        name[b] = name[c];
                        name[c] = tempname1;
                        int tempmark1 = mark[b];
                        mark[b] = mark[c];
                        mark[c] = tempmark1;
                    }
                }
            }

            Console.WriteLine("Sorted by alphabetically.");
            for (int d = 0; d < name.Length; d++)
            {
                Console.WriteLine("{0}\t{1}", name[d], mark[d]);
            }
        }
    }
}
