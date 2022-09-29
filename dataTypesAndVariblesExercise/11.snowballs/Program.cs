using System;
using System.Numerics;

namespace _11.snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnow = int.MinValue;
            int maxTime = int.MinValue;
            BigInteger snowballValue = 0;
            int snowballQuality = 0;
            int maxQuality = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue=BigInteger.Pow((snowballSnow/snowballTime),snowballQuality);
                if (snowballValue>maxValue)
                {
                    maxValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality= snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = { maxValue} ({ maxQuality})");
        }
    }
}
