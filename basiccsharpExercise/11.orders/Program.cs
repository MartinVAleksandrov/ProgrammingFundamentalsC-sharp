using System;

namespace _11.orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double sum = 0;
            double price = 0;
            for (int i = 1; i <=n; i++)
            {
                double pricePerCap = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                price = days * count * pricePerCap;
                sum += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                price = 0;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
