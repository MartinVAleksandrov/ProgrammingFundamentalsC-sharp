using System;

namespace _03.vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=int.Parse(Console.ReadLine());
            string type=Console.ReadLine(); 
            string day=Console.ReadLine();
            double total = 0;
            switch (type)
            {
                case "Students":
                    if (day=="Friday")
                    {
                        total = count * 8.45;
                    }
                    else if(day=="Saturday")
                    {
                        total = count * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        total = count * 10.46;
                    }
                    if (count>=30)
                    {
                        total -= total * 0.15;
                    }
                    break;
                case "Business":
                    if (count>=100)
                    {
                        count -= 10;
                    }
                    if (day == "Friday")
                    {
                        total = count * 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        total = count * 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        total = count * 16;
                    }
                    break ;
                case "Regular":
                    if (day == "Friday")
                    {
                        total = count * 15;
                    }
                    else if (day == "Saturday")
                    {
                        total = count * 20;
                    }
                    else if (day == "Sunday")
                    {
                        total = count * 22.50;
                    }
                    if (count>=10&&count<=20)
                    {
                        total -= total * 0.05;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
