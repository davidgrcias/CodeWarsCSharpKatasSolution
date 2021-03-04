using System;
using System.Linq;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. " + Kata.Solve("JOEBiden")); // joebiden
            Console.WriteLine("2. " + Kata.Solve("DonaldTRUMP")); // DONALDTRUMP
            Console.WriteLine("3. " + Kata.Solve("DonalDTRUMP")); // DONALDTRUMP
            Console.WriteLine("4. " + Kata.Solve("coDe")); // code
            Console.WriteLine("5. " + Kata.Solve("CODe")); // CODE
            Console.WriteLine("6. " + Kata.Solve("coDE")); // code
            Console.WriteLine("7. " + Kata.Solve("codE")); // code
            Console.WriteLine("8. " + Kata.Solve("CODe")); // CODE
            Console.WriteLine("9. " + Kata.Solve("Hai")); // hai
            Console.WriteLine("10. " + Kata.Solve("Hi")); // hi
            Console.WriteLine("11. " + Kata.Solve("HiHi")); // hihi
            Console.WriteLine("12. " + Kata.Solve("XHiHi")); // XHIHI
            Console.WriteLine("13. " + Kata.Solve("Donald J Trump 2020")); // DONALD J TRUMP 2020

            Console.ReadLine();
        }
    }

    // Fix string case

    // In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:

    // make as few changes as possible.
    // if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.
    // For example:

    // solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
    // solve("CODe") = "CODE". Uppercase characters > lowecase. Change only the "e" to uppercase.
    // solve("coDE") = "code". Upper == lowercase. Change all to lowercase.
    // More examples in test cases. Good luck!

    // Please also try:

    // Simple time difference

    // Simple remove duplicates

    // FUNDAMENTALS


    class Kata
    {
        public static string Solve(string s)
        {
            string result = "";

            if (s.Count(char.IsLower) < s.Length / 2.0)
            {
                result = s.ToUpper();
            }
            else if (s.Count(char.IsLower) >= s.Length / 2.0)
            {
                result = s.ToLower();
            }

            return result;
            
            
            // Don't forget to use using System.Linq;
        }
    }
}
