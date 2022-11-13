using System;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                int n = input[i].Length;
                for (int k = 0; k < n; k++)
                {


                    Console.Write($"{input[i]}");
                }
            }
        }
    }
}
