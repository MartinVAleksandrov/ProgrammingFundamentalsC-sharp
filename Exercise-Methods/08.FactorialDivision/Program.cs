using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            decimal sumA = FactorialDivision(a);
            decimal sumB = FactorialDivision(b);
           decimal sumC = sumA/sumB;
            Console.WriteLine($"{sumC:f2}");
        }
        static decimal FactorialDivision(int input)
        {
            decimal sum = 1;
            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }


            return  sum;
        }
    }
}
