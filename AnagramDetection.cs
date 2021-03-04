using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsAnagram("ekoc", "coke")); // true
            Console.WriteLine(Kata.IsAnagram("dumble", "bumble")); // false
            Console.WriteLine(Kata.IsAnagram("TwoO", "Woot")); // true
            Console.WriteLine(Kata.IsAnagram("apple", "palee")); // false
            Console.WriteLine(Kata.IsAnagram("ound", "round")); // false
            Console.WriteLine(Kata.IsAnagram("buckethead", "DeathCubek")); // true

            Console.ReadLine();
        }
    }

    //  Anagram Detection (7 Kyu)

    //  An anagram is the result of rearranging the letters of a word to produce a new word(see wikipedia).

    //  Note: anagrams are case insensitive

    //  Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.

    //  Examples
    //  "foefet" is an anagram of "toffee"

    //  "Buckethead" is an anagram of "DeathCubeK"

    //  FUNDAMENTALS, STRINGS

    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            test = test.ToLower(); // change test to lowercase
            original = original.ToLower(); // change original to lowercase

            char[] testArr = (test.ToCharArray()); // change test to char array
            char[] oriArr = (original.ToCharArray()); // change original to char array

            Array.Sort(testArr); // sorted into A-Z order
            Array.Sort(oriArr); // sorted into A-Z order

            string s1, s2;

            s1 = new string(testArr); // make a new string from testArr
            s2 = new string(oriArr); // make a new string from oriArr

            if (s1 == s2) // if s1(testArr) equal s2(oriArr)
            {
                return true;
            }

            return false; // else
        }
    }
}
