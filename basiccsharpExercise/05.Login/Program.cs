using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;

            }
            int totalTry = 0;
            string eneredpass;
            while ((eneredpass = Console.ReadLine()) != password)
            {
                totalTry++;
                if (totalTry >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
            if (totalTry < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
