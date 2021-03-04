using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Factorial(5)); // 5 * 4 * 3 * 2 * 1 = 120
            Console.WriteLine(Kata.Factorial(1)); // 1 * 1 = 1
            Console.WriteLine(Kata.Factorial(6)); // 6 * 5 * 4 * 3 * 2 * 1 = 720
            Console.WriteLine(Kata.Factorial(0)); // 1
            Console.WriteLine(Kata.Factorial(2)); // 2 * 1 = 2
            Console.WriteLine(Kata.Factorial(4)); // 4 * 3 * 2 * 1 = 24
            Console.WriteLine(Kata.Factorial(13)); // ArgumentOutOfRangeException
        }
    }

    // Factorial ( 7 Kyu )

    // In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n.For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

    // Write a function to calculate factorial for a given input.If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java) or RangeException (PHP) or throw a RangeError (JavaScript) or ValueError (Python) or return -1 (C).

    // More details about factorial can be found here.

    // FUNDAMENTALS, ALGORITHMS, NUMBERS

    public static class Kata
    {
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12) // if n below 0 or above 12
            {
                throw new ArgumentOutOfRangeException();
            }

            if (n == 0) // if n equal 0
            {
                return 1;
            }

            int s = n; // s equal n

            for (int i = 1; i < s; i++)  // Example => n = 5, so s = 5        i = 1, 2, 3, 4
            {
                n = n * i; // Example => 5         5 * 1 * 2 * 3 * 4 = 120
            }

            return n;
        }
    }
}
