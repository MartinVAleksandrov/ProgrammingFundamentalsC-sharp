using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                {
                    Console.Write(input[i]);
                }
            }
           // Console.WriteLine();
           // List<char> digits=input.Where(Char.IsDigit).ToList();
           // Console.WriteLine(string.Join("",digits));
        }
    }
}
