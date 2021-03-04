using System;

namespace CodeWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Kata.SequenceSum(2, 6, 2)); // EXAMPLE : start = 2, end = 6, step = 2 => 2(start) + 2(step) = 4 + 2(step) = 6 <= 6(end)       => 0 + 2 + 4 + 6 = 12, returns 12
            Console.WriteLine(Kata.SequenceSum(1, 5, 1));
            Console.WriteLine(Kata.SequenceSum(1, 5, 3));
            Console.WriteLine(Kata.SequenceSum(0, 15, 3)); // EXAMPLE : start = 0, end = 15, step = 3 => 0(start) + 3(step) = 3 + 3(step) = 6 + 3(step) = 9 + 3(step) = 12 + 3(step) = 15(end)       => 0 + 0 + 3 + 6 + 9 + 12 + 15 = 45, returns 45
            Console.WriteLine(Kata.SequenceSum(16, 15, 3));
            Console.WriteLine(Kata.SequenceSum(2, 24, 22)); // EXAMPLE : start = 2, end = 24, step = 22 => 2(start) + 22(step) = 24 <= 24(end)       => 0 + 2 + 24  = 26, returns 26
            Console.WriteLine(Kata.SequenceSum(2, 2, 2)); // start = 2, end = 2, step = 2       => 0 + 2 = 2, returns 2
            Console.WriteLine(Kata.SequenceSum(2, 2, 1));
            Console.WriteLine(Kata.SequenceSum(15, 1, 3)); // because start/begin is greater than the end, should return = 0
            Console.WriteLine(Kata.SequenceSum(1, 15, 3));
        }
    }

    // Sum of a sequence ( 7 Kyu )

    // Your task is to make function, which returns the sum of a sequence of integers.

    // The sequence is defined by 3 non-negative values: begin, end, step.

    // If begin value is greater than the end, function should returns 0

    // Examples

    // SequenceSum(2,2,2); // => 2
    // SequenceSum(2,6,2); // => 12 -> 2 + 4 + 6
    // SequenceSum(1,5,1); // => 15 -> 1 + 2 + 3 + 4 + 5
    // SequenceSum(1,5,3); // => 5 -> 1 + 4
    // This is the first kata in the series:

    // Sum of a sequence(this kata)
    // Sum of a Sequence[Hard - Core Version]
    //FUNDAMENTALS, NUMBERS, RECURSION, ALGORITHMS, COMPUTABILITY THEORY, THEORETICAL COMPUTER SCIENCE, LOOPS, CONTROL FLOW, BASIC LANGUAGE FEATURES

    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }

            int sum = 0;
            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }
            return sum;
        }
    }
}
