using System;
using System.Collections.Generic;
using System.Text;

namespace swapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Enter  first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapp ");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Wapping of number:");
        }
    }
}
