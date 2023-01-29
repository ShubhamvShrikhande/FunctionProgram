using System;
using System.Collections.Generic;
using System.Text;

namespace largestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // int b = 20;
            // int c = 50;
            Console.WriteLine("Enter first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the therd number");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Number One is the Largest");
            }
            else if (b > c)
            {
                Console.WriteLine("Number  two is the Largest");
            }
            else if (c > a)
            {
                Console.WriteLine("Number therd is Largest");
            }
        }
    }
}
