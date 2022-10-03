using System;

namespace _09.kaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dna = "";
            while ( (dna=Console.ReadLine())!= "Clone them!")
            {
                dna = dna.Replace("!","");
            }
            
        }
    }
}
