using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            int sum = SumMetod(a,b);
            int input = SubMetod(sum, c);
            Console.WriteLine(input);
        }
        static int SumMetod(int a,int b)
        {
            int sum =a+b;
            return sum;
        }
        static int SubMetod(int sum, int c)
        {
            return sum-c;
        }
    }
}
