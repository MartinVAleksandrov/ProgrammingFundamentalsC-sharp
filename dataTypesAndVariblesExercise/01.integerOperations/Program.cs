using System;

namespace _01.integerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());
            int second=int.Parse(Console.ReadLine());
            int therd=int.Parse(Console.ReadLine());
            int fort=int.Parse(Console.ReadLine());
            int sum = first + second;
            sum = sum / therd;
            sum = sum * fort;
            Console.WriteLine(sum);
        }
    }
}
