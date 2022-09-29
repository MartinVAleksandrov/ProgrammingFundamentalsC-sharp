using System;

namespace _12.sortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1=int.Parse(Console.ReadLine());
            int n2=int.Parse(Console.ReadLine());
            int n3=int.Parse(Console.ReadLine());
            int max = 0;
            if (n3>n2&&n3>n1)
            {
                Console.WriteLine(n3);
                max = n3;
            }
            else if (n2>n3&&n2>n1)
            {
                Console.WriteLine(n2);
                max = n2;
            }
            else if (n1>n3&&n1>n2)
            {
                Console.WriteLine(n1);
                max = n1;
            }
            if (max==n3&&n2>n1)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n1);
            }
            else if (max == n3 && n1 > n2)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);
            }
            if (max == n2 && n3 > n1)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n1);
            }
            else if (max == n2 && n1 > n3)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n3);
            }
            if (max == n1 && n3 > n2)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n2);
            }
            else if (max == n1 && n2 > n3)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n3);
            }
            
        }
    }
}
