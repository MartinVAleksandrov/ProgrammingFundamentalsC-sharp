using System;

namespace _04.sumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char alphabet = char.Parse(Console.ReadLine());
                sum += alphabet;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
