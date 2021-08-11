using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int ch = Convert.ToInt32(Console.ReadLine());
            if(ch>=35 && ch<=100)
                Console.WriteLine("valid");
            else
                Console.WriteLine($"not {ch} valid");
            Console.WriteLine("Enter marks of M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks P");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks C");
            int c = Convert.ToInt32(Console.ReadLine());
            float avg=(float)(m+p+c)/ 3;
            Console.WriteLine($"The avg is {avg}");
            int total = p + m + c;
            Console.WriteLine($"The total is {total}");
            string res = string.Empty;
            string grade = string.Empty;
            if (c>=35 && m>=35 && p>=35)
                    res = "PASS";
            if (avg > 75)
                grade = "A";
            else if (avg < 75 && avg > 60)
                grade = "B";
            else
                res = "FAIL";
            Console.WriteLine($"res is {res},Grade {grade}");

        }
    }
}
