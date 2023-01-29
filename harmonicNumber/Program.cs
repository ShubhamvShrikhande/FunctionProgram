using System;
using System.Collections.Generic;
using System.Text;

namespace harmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Harmonic Number you wants: ");
            int n = Convert.ToInt32(Console.ReadLine()); // eg. 3rd no , n = 3

            int i = 1;
            decimal harmonicNo = 0;

            for (i = 1; i <= n; i++)
            {
                harmonicNo = harmonicNo + (1 / (decimal)i); // 1 + 1/2 + 1/3
            }

            Console.WriteLine("Harmonic Number is " + harmonicNo);
        }
    }
}
