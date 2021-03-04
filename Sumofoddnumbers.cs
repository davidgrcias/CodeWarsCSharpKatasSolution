using System;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.rowSumOddNumbers(42));
            Console.WriteLine(Kata.rowSumOddNumbers(1));
            Console.WriteLine(Kata.rowSumOddNumbers(2));
            Console.WriteLine(Kata.rowSumOddNumbers(3));
            Console.WriteLine(Kata.rowSumOddNumbers(10));
            Console.WriteLine(Kata.rowSumOddNumbers(5));
            Console.WriteLine(Kata.rowSumOddNumbers(4));
            Console.WriteLine(Kata.rowSumOddNumbers(72));

            Console.ReadKey(true);
            Console.ReadLine();
        }
    }

    // Given the triangle of consecutive odd numbers:

    //              1
    //           3     5
    //        7     9    11
    //     13    15    17    19
    //  21    23    25    27    29
    // Calculate the row sums of this triangle from the row index(starting at index 1) e.g.:

    // rowSumOddNumbers(1); // 1
    // rowSumOddNumbers(2); // 3 + 5 = 8
    // FUNDAMENTALS, ARRAYS, LISTS, DATA STRUCTURES, NUMBERS, ARITHMETIC, MATHEMATICS, ALGORITHMS

    public static class Kata
    {
        public static long rowSumOddNumbers(long n)
        {
            return n * n * n;
        }
    }
}
