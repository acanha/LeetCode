using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Problem344
{
    /*
        Write a function that takes a string as input and returns the string reversed.

        Example:
        Given s = "hello", return "olleh".

        URL: https://leetcode.com/problems/reverse-string/description/
    */
    public string Solution(string s)
    {
        char[] reversed = s.ToArray();
        int half   = s.Length / 2;
        int length = s.Length - 1;

        for (int firstIndex = 0; firstIndex < half; firstIndex++)
        {
            int secondIndex = length - firstIndex;
            char firstHalf  = reversed[firstIndex];
            char secondHalf = reversed[secondIndex];

            reversed[firstIndex]  = secondHalf;
            reversed[secondIndex] = firstHalf;
        }

        return new string(reversed);
    }
}