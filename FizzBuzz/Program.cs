using System;
using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz
{
    public class Program
    {
        private const int MAX = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Let the game begins:");
            FizzBuzz();
            Console.WriteLine("Type anything to exit.");
            Console.ReadLine();
        }

        private static void FizzBuzz()
        {
            for (int i = 1; i <= MAX; i++)
            {
                if (IsDivisibleBy(i, 3) || hasNumber(i, 3))
                {
                    Console.WriteLine("Fizz");
                }
                else if (IsDivisibleBy(i, 5) || hasNumber(i, 5))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool hasNumber(int i, int v)
        {
            //i know there will be a max of 3 digit
            List<int> digits = new List<int>();
            digits.Add(i / 100);
            i = i % 100;
            digits.Add(i/10);
            i = i % 10;
            digits.Add(i);

            foreach (int digit in digits)
            {
                if (digit == v)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsDivisibleBy(int i, int j)
        {
            return i % j == 0;
        }
    }
}
