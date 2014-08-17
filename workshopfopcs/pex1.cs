using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class pex1
    {
        static void Main(string[] args)
        { 
            // request name and print a greeting
            Console.WriteLine("Please enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning {0} \nwhere {1} is the name you had input.", name, name);
        }
    }
}
