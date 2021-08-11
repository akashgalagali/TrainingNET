using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lmr");
            int lmr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pmr");
            int pmr = Convert.ToInt32(Console.ReadLine());
            int bu = pmr - lmr;
            double ur;
            if (bu < =150)
                ur = 1.75;
            else if (bu > 150 && bu <= 375)
                ur = 3.25;
            else if (bu > 375 && bu < 500)
                ur = 5;
            else
                ur = 6;
            Console.WriteLine($"the LMR is {lmr} PMR is {pmr} BU is {bu} ur is {ur}");

        }
    }
}
