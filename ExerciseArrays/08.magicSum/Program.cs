using System;
using System.Linq;

namespace _08.magicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length-1; j++)
                {


                    if (numbers[i] + numbers[j+1] == num)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j + 1]}");
                    }
                }
            }
        }
    }
}
