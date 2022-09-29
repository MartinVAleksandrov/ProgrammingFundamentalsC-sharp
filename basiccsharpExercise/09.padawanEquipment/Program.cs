using System;

namespace _09.padawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money=double.Parse(Console.ReadLine());  
            int count= int.Parse(Console.ReadLine());
            double priceLight=double.Parse(Console.ReadLine());
            double priceRobes=double.Parse(Console.ReadLine());
            double priceBelts=double.Parse(Console.ReadLine());
            double sumNeeded=0;
            double sumLight = priceLight * count+Math.Ceiling(count*0.1)*priceLight;
            double sumRobes = priceRobes * count;
            double sumBelts=priceBelts * (count-(count/6));
            sumNeeded = sumLight + sumRobes + sumBelts;

            if (sumNeeded<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {sumNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(sumNeeded-money):f2}lv more.");
            }

        }
    }
}
