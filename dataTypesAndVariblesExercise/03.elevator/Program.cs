using System;

namespace _03.elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double elevate = Math.Ceiling(number / (double)capacity);



            Console.WriteLine(elevate);

        }
    }
}

