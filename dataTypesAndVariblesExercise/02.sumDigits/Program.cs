using System;

namespace _02.sumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            n=Math.Abs(n);  
            while (n!=0)
            {
                int chek = n % 10;
                sum += chek;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
