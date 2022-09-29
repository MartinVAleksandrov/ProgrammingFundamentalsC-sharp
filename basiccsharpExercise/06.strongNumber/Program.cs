using System;

namespace _06.strongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int end = n;
            int num = 0;
            int sum = 1;
            int total = 0;
           while(n!=0)
            {


                num = n % 10;
                for (int i = num; i > 0; i--)
                {
                    sum *= i;
                }
                total += sum;
                n /= 10;
                sum = 1;
            }
            if (end==total)
            {

                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
