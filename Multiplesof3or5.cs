using System;

    // Multiples of 3 or 5 ( 6 Kyu )

    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    // Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

    // "Note: If the number is a multiple of both 3 and 5, only count it once. Also, if a number is negative, return 0(for languages that do have them)"

    // Courtesy of projecteuler.net

    // ALGORITHMS, MATHEMATICS, NUMBERS

namespace CodeWars
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution(10));
            // i % 3 = 0 => 3, 6, 9 < (10)
            // i % 5 = 0 => 5 < (10)
            // sum = 3 + 5 + 6 + 9 = 23, so the output is 23

            Console.WriteLine(Kata.Solution(22));
            // i % 3 = 0 => 3, 6, 9, 12, 15, 18, 21 < (22)
            // i % 5 = 0 => 5, 10, 15, 20 < (22)
            // sum = 3 + 6 + 9 + 12 + 15 + 18 + 21 + 5 + 10 + 15 + 29 = 119, so the output is 119

            Console.WriteLine(Kata.Solution(30));
        }
    }
}
