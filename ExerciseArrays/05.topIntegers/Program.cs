using System;
using System.Linq;

namespace _05.topIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int one = 0;
            int two = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                bool flag = true;

                for (int j = i +1; j < numbers.Length  ; j++)
                {

                    one=numbers[i];
                    two=numbers[j];
                    if (one <= two)
                    {
                        
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

        }
    }
}
