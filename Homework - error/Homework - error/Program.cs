using System;

namespace Homework___error
{
    public enum Unauthorized
    {
        Unauthorized = 1, InvalidCastException = 2, ArgumentException = 3, NullReferenceException = 4
    }

    class Error
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1-4 , that know error");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Unauthorized");
            }
            else if (x == 2)
            {
                Console.WriteLine("InvalidCastException");
            }
            else if (x == 3)
            {
                Console.WriteLine("ArgumentException");
            }
            else if (x == 4)
            {
                Console.WriteLine("NullReferenceException");
            }
            else
            {
                Console.WriteLine("Enter the number 1-4 , that know error");
            }

        }
    }

}
