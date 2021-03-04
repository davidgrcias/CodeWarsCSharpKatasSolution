using System;

namespace CodeWars
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* 
              In number theory, a narcissistic number in a given number base b is a number that is
              the sum of its own digits each raised to the power of the number of digits
            */

            Console.WriteLine(Kata.Narcissistic(153)); // true, because the result is the same as the original number, that is 153
            Console.WriteLine(Kata.Narcissistic(1652)); // false, because the result is not the same as the original number 
            Console.WriteLine(Kata.Narcissistic(370)); // true, because the result is the same as the original number, that is 370
            Console.WriteLine(Kata.Narcissistic(371)); // true, because the result is the same as the original number, that is 371
            Console.WriteLine(Kata.Narcissistic(407)); // true, because the result is the same as the original number, that is 407
            Console.WriteLine(Kata.Narcissistic(328)); // false, because the result is not the same as the original number
            Console.WriteLine(Kata.Narcissistic(629)); // false, because the result is not the same as the original number
        }
    }

    // Does my number look big in this? ( 6 Kyu )

    // A Narcissistic Number is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to decimal (base 10).

    // For example, take 153 (3 digits), which is narcisstic:
    // 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

    // and 1652 (4 digits), which isn't:
    // 1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938

    // The Challenge:

    // Your code must return true or false depending upon whether the given number is a Narcissistic number in base 10.

    // Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers will be passed into the function.

    // ALGORITHMS, NUMBERS

    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            string valueString = Convert.ToString(value.ToString());

            double result = 0;

            for (int i = 0; i < valueString.Length; i++)
            {
                result += Math.Pow(int.Parse(valueString.Substring(i, 1)), valueString.Length);
            }

            bool resultBool;

            if (result == value)
            {
                resultBool = true;
            }
            else
            {
                resultBool = false;
            }

            return resultBool;
        }
    }
}
