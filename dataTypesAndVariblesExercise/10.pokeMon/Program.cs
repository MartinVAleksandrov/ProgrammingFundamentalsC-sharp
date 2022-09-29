using System;

namespace _10.pokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int origoinal = n;
            int count = 0;
            while (n >= m)
            {
                n -= m;
                count++;
                if (n == origoinal * 0.5)
                {
                    if (y != 0)
                    {


                        n /= y;
                    }

                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
