using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            MiddleCharacters(input);
        }
        static void MiddleCharacters(string input)
        {
            if (input.Length%2==0)
            {
                int i=input.Length/2;
                Console.Write(input[i-1]);
                Console.Write(input[i]);
            }
            else
            {
                int i = input.Length / 2;
                Console.Write(input[i]);
                
            }
        }
    }
}
