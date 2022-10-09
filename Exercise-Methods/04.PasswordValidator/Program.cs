using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            IsSixChars(input);
        }
        static void IsSixChars(string input)
        {
            bool flag=true;
            if (input.Length<6||input.Length>11)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                flag=false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 48 && input[i]<=57)|| (input[i] >= 65 && input[i] <= 90)|| (input[i] >= 97 && input[i] <= 122))
                {

                }
                else
                {
                    
                    flag = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }
            int count=0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i]<=57)
                {
                    count++;
                }
            }
            if (count<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                flag = false;
            }
            if(flag)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
