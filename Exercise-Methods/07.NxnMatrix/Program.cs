using System;

namespace _07.NxnMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxnMatrix(n);
        }
        static void NxnMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
