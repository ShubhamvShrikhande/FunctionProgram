using System;
using System.Collections.Generic;
using System.Text;

namespace VowelORconsont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any char A-Z");
            char ch = char.Parse(Console.ReadLine());
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u')
                || (ch == 'A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U'))
            {
                Console.WriteLine(ch + "is vowel");
            }
            else if ((ch >= 'a') && (ch <= 'z') || (ch >= 'A') && (ch <= 'Z'))
            {
                Console.WriteLine("is consont");
            }
        }
    }
}
