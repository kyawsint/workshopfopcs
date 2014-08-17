using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex17
    {
        static void Main(string[] args)
        {
            string name, gender;
            int age;
            name = getdata("name");
            gender = getdata("gender (M or F)");
            age = Convert.ToInt32(getdata("age"));
            if (gender == "M")
            {
                if (age < 40)
                {
                    Console.WriteLine("Good morning {0}!", "Mr. " + name);
                }
                else
                {
                    Console.WriteLine("Good morning {0}!", "Uncle " + name);
                }
            }
            else if (gender == "F")
            {
                if (age < 40)
                {
                    Console.WriteLine("Good morning {0}!", "Ms. " + name);
                }
                else
                {
                    Console.WriteLine("Good morning {0}!", "Aunty " + name);
                }
            }
        }

        static string getdata(string str)
        {
            Console.Write("Enter your {0} : ", str);
            return (Console.ReadLine());
        }
    }
}
