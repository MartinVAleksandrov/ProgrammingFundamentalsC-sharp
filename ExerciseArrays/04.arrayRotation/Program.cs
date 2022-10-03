using System;

namespace _04.arrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] newArray=Console.ReadLine()
                .Split(" ");
            int rotation=int.Parse(Console.ReadLine());
            for (int i = 0; i < rotation; i++)
            {
                string firstElement = newArray[0];
                for (int j = 0; j < newArray.Length-1; j++)
                {
                    newArray[j] = newArray[j+1];
                }
                newArray[newArray.Length-1] = firstElement;
            }
            Console.WriteLine(string.Join(" ",newArray));
        }
    }
}
