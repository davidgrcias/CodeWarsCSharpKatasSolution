using System;

namespace CodeWars
{

    // Duplicate Encoder ( 6 Kyu )

    // The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

    // Examples
    // "din"      =>  "((("
    // "recede"   =>  "()()()"
    // "Success"  =>  ")())())"
    // "(( @"     =>  "))(("
    // Notes

    // Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!

    //FUNDAMENTALS, STRINGS, ARRAYS

    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower(); // Ignore capitalization when determining if a character is a duplicate.
            string brackets = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word.IndexOf(word.Substring(i,1)) == word.LastIndexOf(word.Substring(i, 1))) // if just once; because if the letter is only once in the same place then the index will be the same (==)
                {
                    brackets += "(";
                }
                else if (word.IndexOf(word.Substring(i, 1)) != word.LastIndexOf(word.Substring(i, 1))) // else if more than once; because if the letter more than once in the different place, then the index won't be same (!=)
                {
                    brackets += ")";
                }
            }

            return brackets;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.DuplicateEncode("Success")); //  )())())
            Console.WriteLine(Kata.DuplicateEncode("recEde")); // ()()()
            Console.WriteLine(Kata.DuplicateEncode("din")); // (((
            Console.WriteLine(Kata.DuplicateEncode("(( @")); // ))((
            Console.WriteLine(Kata.DuplicateEncode("((  @@")); // ))))))
            Console.WriteLine(Kata.DuplicateEncode("DoWnY")); // (((((

            /*
            EXAMPLE => "Success"
                    => the letter 's' is more than once because the letter 's' is in 3 places that is in [0], [5], and [6]     [0] = ) [5] = ) [6] = )
                    => the letter 'u' is just once because the letter 'u' is just in 1 place that is in [1]      [1] = (
                    => the letter 'c' is more than once because the letter 'c' is in 2 places that is in [2] and [3]      [2] = ) [3] = )
                    => the letter 'e' is juts once because the letter 'e' is just in 1 place that is in [4]      [4] = (

                    so, the result is [0][1][2][3][4][5][6] = )())())
            */
        }
    }
}
