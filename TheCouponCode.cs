using System;

namespace ConsoleApp104
{
    // Story
    // Your online store likes to give out coupons for special occasions.Some customers try to cheat the system by entering invalid codes or using expired coupons.

    // Task
    // Your mission:
    // Write a function called checkCoupon which verifies that a coupon code is valid and not expired.

    // A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".

    // Examples:
    // CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015")  ==  true
    // CheckCoupon("123", "123", "July 9, 2015", "July 2, 2015")  ==  false
    // FUNDAMENTALS, FUNCTIONS, CONTROL FLOW, BASIC LANGUAGE FEATURES, DATES/TIME, STRINGS

    public static class Kata
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            if (enteredCode == correctCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate))
            {
                return true;
            }
            else if (enteredCode == correctCode && DateTime.Parse(currentDate) > DateTime.Parse(expirationDate))
            {
                return false;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015")); // July 9, 2015 <= July 9, 2015 == true
            Console.WriteLine(Kata.CheckCoupon("123", "123", "July 9, 2015", "July 2, 2015")); // July 9, 2015 > July 2, 2015 == false
            Console.WriteLine(Kata.CheckCoupon("123", "123", "July 15, 2015", "July 14, 2015")); // July 15, 2015 > July 14, 2015 == false
            Console.WriteLine(Kata.CheckCoupon("200", "200", "September 05, 2005", "September 13 2020")); // September 05, 2005 <= September 13, 2020 == true
            Console.WriteLine(Kata.CheckCoupon("200", "200", "September 13, 2019", "September 13 2019")); // September 13, 2019 <= September 13, 2019 == true

            Console.ReadKey(true);
            Console.ReadLine();
        }
    }
}
