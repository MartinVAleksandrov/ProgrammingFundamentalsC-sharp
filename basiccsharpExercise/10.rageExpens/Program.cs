using System;

namespace _10.rageExpens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGame=int.Parse(Console.ReadLine());
            double headset=double.Parse(Console.ReadLine());
            double mouse=double.Parse(Console.ReadLine());
            double keyboard=double.Parse(Console.ReadLine());
            double display=double.Parse(Console.ReadLine());
            double sum=lostGame/2*headset+lostGame/3*mouse+lostGame/6*keyboard+lostGame/12*display;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
    }
}
