using System;
using System.Collections.Generic;
using System.Text;

namespace leapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("this is leap year");
            }
            else
            {
                Console.WriteLine("this not leap year");
            }

        }
    }
    
}
