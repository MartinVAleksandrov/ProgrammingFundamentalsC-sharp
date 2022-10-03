using System;
using System.Linq;

namespace _03.zigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] first=new int[n];
            int[] second=new int[n];
            int[] newArray=new int[2];
            for (int i = 0; i < n; i++)
            {
                newArray=Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i%2==0)
                {
                    first[i] = newArray[0];
                    second[i] = newArray[1];
                }
                else
                {
                    first[i] = newArray[1];
                    second[i] = newArray[0];
                }
            }
            Console.WriteLine(string.Join(" ",first));
            Console.WriteLine(string.Join(" ",second));
        }
    }
}
