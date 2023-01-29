using System;
using System.Collections.Generic;
using System.Text;

namespace powerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int power = 1;
            int i = 1;
            Console.WriteLine("Enter the Power: ");
            int p = Convert.ToInt32(Console.ReadLine());

            if (p >= 0 && p < 31)
            {
                for (i = 1; i <= p; i++)
                {
                    power = power * num;  //1*2 = 2 , 2*2 =4 , , 4*2 =8
                    Console.WriteLine(power);
                }
            }
            else
            {
                Console.WriteLine("Please enter power between 0-31");
            }
        }
    }
}
