using System;

namespace Homework___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"l = 2*pi*r = {2 * Math.PI * a } ");
                Console.WriteLine($"S = pi*r*r =  {Math.PI * a * a }");
                Console.WriteLine($"V = 4/3*pi*r*r*r = {4 / 3 * Math.PI * a * a * a}");
            }
            else
            {
                Console.WriteLine("Raduis is negative");
            }
        }
    }
}
