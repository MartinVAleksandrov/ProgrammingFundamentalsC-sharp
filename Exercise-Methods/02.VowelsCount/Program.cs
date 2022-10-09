using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int result=Counter(input);
            Console.WriteLine(result);
        }
        static int Counter(string input)
        {
            int count = 0;
            input=input.ToLower();
            
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i]=='a'|| input[i] == 'o' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u') 
                {
                    count++;
                }
            }
            return count;
        }

    }
}
