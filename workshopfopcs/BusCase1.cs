using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshopfopcs
{
    class BusCase1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount : ");
            string amt = Console.ReadLine();
            string word = numtoword(amt);
            Console.WriteLine("Dollar {0} only.", word);
        }

        static string numtoword(string amt)
        {
            int num; double d = 0;
            if (amt.Contains('.'))
            {
                num = Convert.ToInt32(amt.Split('.')[0]);
                d = Convert.ToDouble("." + Convert.ToDouble(amt.Split('.')[1]));
            }
            else
            {
                num = Convert.ToInt32(amt);
            }

            if (num == 0)
                return "Zero";
            if (num < 0)
                return "Minus";
            if (num > 10000)
                return "The bill will always be less than 10000.";

            string words = "";

            if ((num / 1000) > 0)
            {
                words += numtoword((num / 1000).ToString()) + " Thousand ";
                num %= 1000;
            }
            if ((num / 100) > 0)
            {
                words += numtoword((num / 100).ToString()) + " hundred";
                num %= 100;
            }

            if (num > 0)
            {
                if (words != "")
                    words += " and ";
                string[] unit = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nighteen" };
                string[] ten = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (num < 20)
                {
                    words += unit[num];
                }
                else
                {
                    words += ten[num / 10];
                    if ((num % 10) > 0)
                        words += " " + unit[num % 10];
                }
                if (d > 0)
                {
                    words += " and Cents ";
                    words += ten[Convert.ToInt32(d / 0.1)];
                    //Console.WriteLine(d*100/10);
                    if ((d % 0.1) > 0)
                        words += " " + unit[Convert.ToInt32(d / 0.1)];
                }
            }
            return words;
        }




        //static void Main(string[] args)
        //{
        //    Console.Write("Enter amounts : ");
        //    int amt = Convert.ToInt32(Console.ReadLine());
        //    string str = numtoword(amt);
        //    Console.WriteLine("{0} {1}", amt, str);
        //}

        //public static string numtoword(int num)
        //{
        //    if (num == 0)
        //        return "Zero";
        //    if (num < 0)
        //        return "Minus ";
        //    if (num > 10000)
        //        return "The bill will always be less than 10000.";

        //    string words = "";

        //    //if ((num / 1000000) > 0)
        //    //{
        //    //    words += numtoword(num / 1000000) + " Million";
        //    //    num %= 1000000;
        //    //}
        //    if ((num / 1000) > 0)
        //    {
        //        words += numtoword(num / 1000) + " Thousand";
        //        num %= 1000;
        //    }
        //    if ((num / 100) > 0)
        //    {
        //        words += numtoword(num / 100) + " hundred";
        //        num %= 100;
        //    }


        //    if (num > 0)
        //    {
        //        if (words != "")
        //            words += " and ";
        //        string[] unit = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nighteen" };
        //        string[] ten = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        //        if (num < 20)
        //            words += unit[num];
        //        else
        //        {
        //            words += ten[num / 10];
        //            if ((num % 10) > 0)
        //                words += " " + unit[num % 10];
        //        }
        //    }
        //    return words;
        //}
    }
}
