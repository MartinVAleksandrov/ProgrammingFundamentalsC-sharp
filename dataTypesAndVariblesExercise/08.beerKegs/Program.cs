using System;

namespace _08.beerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string bigestModel = "";
            double bigestVolume = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius=double.Parse(Console.ReadLine()); 
                int height=int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume>bigestVolume)
                {
                    bigestVolume = volume;
                    bigestModel = model;
                }

            }
            Console.WriteLine(bigestModel);
        }
    }
}
