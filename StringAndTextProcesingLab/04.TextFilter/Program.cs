using System;
using System.Text;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banedWords=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string text=Console.ReadLine();
            for (int i = 0; i < banedWords.Length; i++)
            {
                StringBuilder word = new StringBuilder();
                for (int k = 0; k < banedWords[i].Length; k++)
                {
                    word.Append("*");
                }
                text = text.Replace(banedWords[i], word.ToString());
                

            }
            Console.WriteLine(text);
        }
    }
}
