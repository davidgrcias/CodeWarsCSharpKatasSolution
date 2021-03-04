using System;

namespace CodeWars
{
    // Word a10n (abbreviation) ( 6 Kyu )

    // The word i18n is a common abbreviation of internationalization in the developer community, used instead of typing the whole word and trying to spell it correctly.Similarly, a11y is an abbreviation of accessibility.

    // Write a function that takes a string and turns any and all "words" (see below) within that string of length 4 or greater into an abbreviation, following these rules:


    // A "word" is a sequence of alphabetical characters.By this definition, any other character like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two words(eg. "elephant" and "ride").
    // The abbreviated version of the word should have the first letter, then the number of removed characters, then the last letter(eg. "elephant ride" => "e6t r2e").
    // Example
    // abbreviate("elephant-rides are really fun!")
    // //          ^^^^^^^^*^^^^^*^^^*^^^^^^*^^^*
    // // words (^):   "elephant" "rides" "are" "really" "fun"
    // //                123456     123     1     1234     1
    // // ignore short words:               X              X

    // // abbreviate:    "e6t"     "r3s"  "are"  "r4y"   "fun"
    // // all non-word characters (*) remain in place
    // //                     "-"      " "    " "     " "     "!"
    // === "e6t-r3s are r4y fun!"
    // FUNDAMENTALS, STRINGS

    public class Abbreviator
    {
        public static string Abbreviate(string input)
        {
            string[] split = input.Split(' ', '-', '.', ';', ',', '.', '\'', ':');

            for (int i = 0; i < split.Length; i++)
            {
                string word = split[i];
                int wordLength = word.Length;

                if (wordLength > 3)
                {
                    string first = word.Substring(0, 1);
                    string number = ((wordLength - 2).ToString());
                    string last = word.Substring(wordLength - 1, 1);

                    string newString = first + number + last;
                    input = input.Replace(word, newString);
                }
            }

            return input;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Abbreviator.Abbreviate("David Garcia Saragih"));
            Console.WriteLine(Abbreviator.Abbreviate("elephant-rides are really fun!"));
            Console.WriteLine(Abbreviator.Abbreviate("internationalization"));
            Console.WriteLine(Abbreviator.Abbreviate("my. dog, isn't feeling very well."));
            Console.WriteLine(Abbreviator.Abbreviate("Mike:Banning"));
            Console.WriteLine(Abbreviator.Abbreviate("cat:dog:monkey;miracle"));

            Console.ReadLine();
        }
    }
}
