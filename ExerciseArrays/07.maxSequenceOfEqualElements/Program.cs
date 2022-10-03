using System;
using System.Linq;

namespace _07.maxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int maxCounter=0;
            int flag1 = 0;
            int flag2= 0;
        
            
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if (numbers[j] == numbers[j+1])
                    {
                        counter++;
                        maxCounter = j;
                        if (counter>flag1)
                        {
                            flag1 = counter;
                            flag2 = maxCounter;
                        }
                    }
                    else
                    {
                        counter=0;
                        maxCounter = 0;
                    }
                }
            int startIndex = flag2 + 1 - flag1;
            

            for (int i = startIndex; i <= flag2+1; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
