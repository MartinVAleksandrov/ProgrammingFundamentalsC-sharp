using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            while (input!="end")
            {
                
                List<char> newInput=input
                    .ToCharArray()
                    .Reverse()
                    .ToList();
                                        
                Console.WriteLine($"{input} = {string.Join("",newInput)}");
                input = Console.ReadLine();
            }
        }
    }
}
