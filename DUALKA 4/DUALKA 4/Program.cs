using System;

namespace DUALKA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter X = ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter Y = ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{X}, {Y}, {(X > 0 && Y > 0)}");
        }
    }
}
