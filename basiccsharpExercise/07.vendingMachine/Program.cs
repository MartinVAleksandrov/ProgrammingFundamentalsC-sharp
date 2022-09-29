using System;

namespace _07.vendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            double sum = 0;
            while (comand != "Start")
            {
                double coin = double.Parse(comand);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    sum += coin;
                }
                comand = Console.ReadLine();
            }

            comand = Console.ReadLine();
            while (comand != "End")
            {
                if (comand == "Nuts")
                {
                    if (sum - 2.0 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {


                        sum -= 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                }
                else if (comand == "Water")
                {
                    if (sum - 0.7 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {


                        sum -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                }
                else if (comand == "Crisps")
                {
                    if (sum - 1.5 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        sum -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                }
                else if (comand == "Soda")
                {
                    if (sum - 0.8 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {


                        sum -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                }
                else if (comand == "Coke")
                {
                    if (sum - 1.0 < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        sum -= 1.0;
                        Console.WriteLine("Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                comand = Console.ReadLine();
            }
            if (comand == "End")
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}
