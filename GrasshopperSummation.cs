//Description:
//Summation
//Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

//For example:

//summation(2) -> 3
//1 + 2

//summation(8) -> 36
//1 + 2 + 3 + 4 + 5 + 6 + 7 + 8

//FUNDAMENTALS | LOOPS | CONTROL FLOW | BASIC LANGUAGE FEATURES

using System;

public static class Kata 
{
    public static int summation(int num)
    {
         int result = 0;
         for (int a = 1; a <= num; a++)
         {
            result += a;
         }
         return result;
    }
}
