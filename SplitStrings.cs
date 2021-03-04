using System;
using System.Collections.Generic;

namespace CodeWars
{

// Split Strings ( 6 Kyu )

// Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

// Examples:

// SplitString.Solution("abc"); // should return ["ab", "c_"]
// SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
// ALGORITHMS, REGULAR EXPRESSIONS, DECLARATIVE PROGRAMMING, ADVANCED LANGUAGE FEATURES, FUNDAMENTALS, STRINGS

    public class SplitString
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
            {
                str += "_";
            }

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str.Substring(i, 1) + str.Substring(i+1, 1));
            }

            return list.ToArray();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SplitString.Solution("abc"));
            Console.WriteLine(SplitString.Solution("abcd"));
            Console.WriteLine(SplitString.Solution("abcdef"));
            Console.WriteLine(SplitString.Solution("ab"));
            Console.WriteLine(SplitString.Solution("abcdefgh"));
            Console.WriteLine(SplitString.Solution("abcdefg"));

            Console.ReadLine();
        }
    }
}
