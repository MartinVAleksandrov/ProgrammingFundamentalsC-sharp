using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintChars(first,second);
        }

         static void PrintChars(char first,char second)
        {
            if (first > second)
            {
                char thurd;
                thurd = first;
                first = second;
                second = thurd;
            }
            for (int i = first + 1; i < second; i++)
            {
                char result = (char)i;
                Console.Write($"{result} ");
            }
        }
    }
}
