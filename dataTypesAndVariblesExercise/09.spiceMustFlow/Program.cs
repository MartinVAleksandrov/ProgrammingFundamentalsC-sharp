using System;

namespace _09.spiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int total = 0;
            int counter = 0;
            for (int i = number; i >= 100; i-=10)
            {
                total += i-26;
                counter++;
                
            }
            total -= 26;
            if (total<0)
            {
                total = 0;
            }
            Console.WriteLine(counter);
            Console.WriteLine(total);
        }
    }
}
