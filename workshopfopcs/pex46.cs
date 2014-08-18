using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex46
    {
        static void Main(string[] args)
        {
            //int[] arrnum = new int[] { 4, 2, 3, 5, 1, 6, 8, 7, 9, 0 };
            int[] arrnum = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int rdmno;
            Random rdm = new Random();
            for (int i = 0; i < arrnum.Length; i++)
            {
                string str = "";
                rdmno = rdm.Next(0, 9);
                //Console.WriteLine("{0}\t{1}", arrnum[i], rdmno);

                for (int j = 0; j < rdmno; j++)
                {
                    str += " *";                   
                }
                Console.WriteLine("{0}\t{1}\t{2}", arrnum[i], rdmno, arrnum[i] + str);
            }
        }
    }
}
