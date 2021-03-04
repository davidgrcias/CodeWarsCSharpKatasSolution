using System;

// IQ Test ( 6 Kyu )

// Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

// ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

// Examples:
// IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

// IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

// FUNDAMENTALS

namespace CodeWars
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            string[] split = numbers.Split(' ');
            int result = 0;
            int countOddResult = 0;
            int countEvenResult = 0;
            for (int i = 0; i < split.Length; i++)
            {
                int countOdd = 1;
                int countEven = 1;
                int number = int.Parse(split[i]);
                if (number % 2 == 1)
                {
                    countOddResult += countOdd++;
                }
                else
                {
                    countEvenResult += countEven++;
                }
            }

            for (int i = 0; i < split.Length; i++)
            {
                if (countOddResult < countEvenResult)
                {
                    for (int y = 1; y <= 1000; y += 2)
                    {
                        if (split[i] == y.ToString())
                        {
                            result = i + 1;
                        }
                    }
                }
                else if(countEvenResult < countOddResult)
                {
                    for (int x = 2; x <= 1000; x += 2)
                    {
                        if (split[i] == x.ToString())
                        {
                            result = i + 1;
                        }
                    }
                }
            }

            return result;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IQ.Test("2 4 7 8 10")); // in this case odd < even. So, we must show our last odd number (7) position that is in third position => 3
            Console.WriteLine(IQ.Test("1 2 1 1")); // in this case even < odd. So, we must show our last even number (2) position that is in second position => 2
            Console.WriteLine(IQ.Test("3 7 8 9")); // in this case even < odd. So, we must show our last even number (8) position that is in third position => 3
            Console.WriteLine(IQ.Test("2 9 6 5")); // in this case even == odd. So, we must return 0 because in 0 position that is nothing => 0
            Console.WriteLine(IQ.Test("10 19 8 7 2")); // in this case odd < even. So, we must show our last odd number (7) position that is in fourth position => 4
            Console.WriteLine(IQ.Test("2 5 10 8 3 66")); // in this case odd < even. So, we must show our last odd number(3) position that is in fifth position => 5
        }
    }
}
