using System;

namespace _13.lastDigit
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());

            string lastDigitAsString = NumberAsString(num);

            Console.WriteLine(lastDigitAsString);           
        }
        public static string NumberAsString(int number)
        {
            number %= 10;
            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 9)
            {
                return "nine";
            }
            else if (number == 0)
            {
                return "zero";
            }
            return "";
        }
    }
}
