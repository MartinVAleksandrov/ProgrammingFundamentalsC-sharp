using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input="";
            while ((input=Console.ReadLine())!="END")
            {
                PalindromeIntegers(input);
            }
        }
        static void PalindromeIntegers(string input)
        {
            string newInput = "";
            for (int i = input.Length-1; i >=0; i--)
            {
                newInput += input[i];
            }
            if (newInput==input)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
