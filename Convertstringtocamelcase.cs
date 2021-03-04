using System;

// Convert string to camel case ( 6 Kyu )

// Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

// Examples
// "the-stealth-warrior" gets converted to "theStealthWarrior"
// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

// ALGORITHMS, REGULAR EXPRESSIONS, DECLARATIVE PROGRAMMING, ADVANCED LANGUAGE FEATURES, FUNDAMENTALS, STRINGS

namespace CodeWars
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            string[] split = str.Split('-', '_');
            var charsToRemove = new string[] { "-", "_" };
            for (int i = 1; i < split.Length; i++)
            {
                string word = split[i];
                int wordLength = word.Length;

                string eachWordFirstLetter = word.Substring(0, 1).ToUpper();
                string rest = word.Substring(1, wordLength - 1).ToLower();
                string result = eachWordFirstLetter + rest;
                str = str.Replace(word, result);
            }
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }
            return str;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("the-stealth-warrior"));
            Console.WriteLine(Kata.ToCamelCase("The_Stealth_Warrior"));
            Console.WriteLine(Kata.ToCamelCase("david_Garcia-saragih"));
        }
    }
}
