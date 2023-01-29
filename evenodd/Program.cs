using System;
using System.Collections.Generic;
using System.Text;

namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to check even or odd: ");
            int num = Convert.ToInt32(Console.ReadLine()); // num = 4

            if (num % 2 == 0)    // 4 % 2 = 0  condition true
            {
                Console.WriteLine($"{num} is even.");//no will be print
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
    }
}
