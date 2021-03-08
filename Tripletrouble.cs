using System;

namespace CodeWars
{
    // Triple trouble ( 6 Kyu )

    // Write a function

    // TripleDouble(long num1, long num2)
    // which takes numbers num1 and num2 and returns 1 if there is a straight triple of a number at any place in num1 and also a straight double of the same number in num2.

    // If this isn't the case, return 0

    // Examples
    // TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and
    //                                           // num2 has straight double 99s

    // TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2

    // TripleDouble(12345, 12345) == 0

    // TripleDouble(666789, 12345667) == 1

    // ALGORITHMS
    public class Kata
    {
        public static int TripleDouble(long num1, long num2)
        {
            for (var i = 0; i <= 9; i++)
            {
                if (num1.ToString().Contains($"{i}{i}{i}") && num2.ToString().Contains($"{i}{i}"))
                {
                    return 1;
                }
            }
            return 0;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.TripleDouble(451999277, 41177722899));
            Console.WriteLine(Kata.TripleDouble(1222345, 12345));
            Console.WriteLine(Kata.TripleDouble(12345, 12345));
            Console.WriteLine(Kata.TripleDouble(666789, 12345667));
        }
    }
}
