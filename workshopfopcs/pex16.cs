using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex16
    {
        static void Main(string[] args)
        {
            string name, gender;
            name = getdata("name");
            gender = getdata("gender (M or F assume capital letter)");
            if (gender == "M")
            {
                Console.WriteLine("Good morning {0} \nwhere you entered {1} for name and {2} for gender.", "Mr." + name, name, gender);
            }
            else
            {
                Console.WriteLine("Good morning {0} \nwhere you entered {1} for name and {2} for gender.", "Ms." + name, name, gender);
            }
        }

        static string getdata(string str)
        {
            Console.Write("Enter your {0} : ", str);
            return (Console.ReadLine());
        }
    }
}
