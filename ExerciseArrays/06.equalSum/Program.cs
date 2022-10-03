using System;
using System.Linq;

namespace _06.equalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool flag=true;
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                for (int k = i; k >=0; k--)
                {
                    leftSum += numbers[k];
                }
                if (rightSum==leftSum)
                {
                    Console.WriteLine(i);
                    flag = false;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (flag)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
