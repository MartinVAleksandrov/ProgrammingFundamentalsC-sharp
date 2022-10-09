using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                TopNumber(i);
            }
        }

        private static void TopNumber(int i)
        {
            bool flag = true;
            string input = i.ToString();
            int sum=0;
            for (int j = 0; j < input.Length; j++)
            {
                sum+=input[j];
            }
            if (sum%8!=0)
            {
                flag = false;
            }
            int count = 0;
            for (int k = 0; k < input.Length; k++)
            {
                if (input[k]%2!=0)
                {
                    count++;
                }
            }
            if (count==0)
            {
                flag=false;
            }
            if (flag)
            {
                Console.WriteLine(i);
            }

        }
    }
}
