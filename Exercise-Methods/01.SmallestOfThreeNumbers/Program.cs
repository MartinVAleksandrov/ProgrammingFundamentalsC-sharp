using System;
using System.Linq;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] input=new int[3] {a,b,c};
            
            int mValue = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                if (input[i] < mValue)
                {
                    mValue = input[i];
                }
            }
            PrintNumbers(mValue);

        }
        static void PrintNumbers(int mValue)
        {
            Console.WriteLine(mValue);
        }
        
    }
}
