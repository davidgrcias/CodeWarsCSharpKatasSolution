using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigPow.digPow(24, 6)); // 2^5 + 4^7 = 16448   16448 % 24 != 0, => = -1
            Console.WriteLine(DigPow.digPow(89, 1)); // 8^1 + 9^2 = 89   89 % 89 == 0, => 89 / 89 = 1
            Console.WriteLine(DigPow.digPow(92, 1)); // 9^1 + 2^2 = 13   13 % 92 != 0, => = -1
            Console.WriteLine(DigPow.digPow(695, 2)); // 6^2 + 9^3 + 5^4 = 1390   1390 % 695 == 0, => 1390 / 695 = 2
            Console.WriteLine(DigPow.digPow(72, 3)); // 7^3 + 2^4 = 359   359 % 72 != 0, => = -1
            Console.WriteLine(DigPow.digPow(46288, 3)); // 4^3 + 6^4 + 2^5 + 8^6 + 8^7 = 2360688   2360688 % 46288 == 0, => 2360688 / 46288 = 51

            Console.ReadLine();
        }
    }

    // Playing with digits ( 6 Kyu )

    // Some numbers have funny properties. For example:

    // 89 --> 8¹ + 9² = 89 * 1

    // 695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

    // 46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

    // Given a positive integer n written as abcd... (a, b, c, d...being digits) and a positive integer p

    // we want to find a positive integer k, if it exists, such as the sum of the digits of n taken to the successive powers of p is equal to k* n.
    // In other words:

    // Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n* k

    // If it is the case we will return k, if not return -1.

    // Note: n and p will always be given as strictly positive integers.

    // digPow(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
    // digPow(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
    // digPow(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
    // digPow(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
    // FUNDAMENTALS, MATHEMATICS, ALGORITHMS, NUMBERS

    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            string nString = Convert.ToString(n.ToString());
            double result = 0;

            for (int i = 0; i < nString.Length; i++)
            {
                int z = p++;
                result += Math.Pow(double.Parse(nString.Substring(i, 1)), z); // z++ during i++
            }

            double result2 = 0;

            if (result % n ==  0)
            {
                result2 = result / n;
            }
            else
            {
                result2 = -1;
            }

            return (long)result2;
        }
    }
}
