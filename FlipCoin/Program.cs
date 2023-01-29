using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many time to flip coin...?");
            int n = Convert.ToInt32(Console.ReadLine()); // eg. n = 10
            int headPer;
            int headCnt = 0, tailCnt = 0;

            for (int i = 1; i <= n; i++) // loops execute 10 times
            {
                Random random = new Random();
                double coin = random.NextDouble(); // randomly in between 0 - 1.0

                if (coin < 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCnt++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCnt++;
                }
            }
        }
    }
}
