using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex18
    {
        static void Main(string[] args)
        {
            // request marks and print grades
            string grade;
            Console.Write("Enter your marks : ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 80 && mark <= 100)
            {
                grade = "A";
            }
            else if (mark >= 60 && mark < 80)
            {
                grade = "B";
            }
            else if (mark >= 40 && mark < 60)
            {
                grade = "C";
            }
            else
            {
                grade = "** Error **";
            }
            Console.WriteLine("Your scroed {0} marks which is {1} grade.", mark, grade);
        }
    }
}
