using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter letter");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"entered char is {ch}");
            Console.WriteLine($"entered char is {(char)(ch+1)}");
            Console.WriteLine($"entered char is {(char)(ch-1)}");
        }
    }
}
/*
 character refers to any letter including alphabet, digit, special letters
  ASCII value for every letter
A - Z   are 65 to 90
a - z are 97 to 122
0 - 9  are 48 to 57 
 */