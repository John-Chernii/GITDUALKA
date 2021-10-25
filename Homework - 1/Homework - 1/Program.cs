using System;

namespace Homework___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            if (X > 0)
            {
                Console.WriteLine($" P = {4 * X}");
                Console.WriteLine($" S = {X * X}");
            }
            else
            {
                Console.WriteLine(" X isn't position");
            }
        }
    }
}
