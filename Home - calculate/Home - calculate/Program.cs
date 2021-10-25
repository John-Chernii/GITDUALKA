using System;

namespace Home___calculate
{
    class Program
    {

        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            int q = 0,
                w = 0,
                e = 0,
                r = 0;
            foreach (int l in str)
            {
                if (l == 'q')
                {
                    q++;
                }
                else if (l == 'w')
                {
                    w++;
                }
                else if (l == 'e')
                {
                    e++;
                }
                else if (l == 'r')
                {
                    r++;
                }
            }
            Console.WriteLine($"q={q}\nw={w}\ne={e}\nr={r}");
        }
    }
}
