using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex33
    {
        static void Main(string[] args)
        {
            int[] arrnum = new int[] { 9, 2, 3, 4, 6, 5, 7, 1, 8, 12, 11, 10 };
            for (int i = 0; i < arrnum.Length; i++)
            {
                for (int j = 0; j < arrnum.Length; j++)
                {
                    if (arrnum[i] > arrnum[j])
                    {
                        int temp = arrnum[i];
                        arrnum[i] = arrnum[j];
                        arrnum[j] = temp;
                    }
                    //if (arrnum[j] > arrnum[i])
                    //{
                    //    int temp = arrnum[j];
                    //    arrnum[j] = arrnum[i];
                    //    arrnum[i] = temp;
                    //}
                }
            }
            for (int a = 0; a < arrnum.Length; a++)
            {
                Console.WriteLine(arrnum[a]);
            }
            //Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",arrnum[0],arrnum[1],arrnum[2],arrnum[3],arrnum[4],arrnum[5],arrnum[6],arrnum[7],arrnum[8],arrnum[9],arrnum[10],arrnum[11]);
            //Console.ReadLine();
        }
    }
}
