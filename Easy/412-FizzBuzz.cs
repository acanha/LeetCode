using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Problem412
{
    /*
        Write a program that outputs the string representation of numbers from 1 to n.

        But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.

        Example:

        n = 15,

        Return:
        [
            "1",
            "2",
            "Fizz",
            "4",
            "Buzz",
            "Fizz",
            "7",
            "8",
            "Fizz",
            "Buzz",
            "11",
            "Fizz",
            "13",
            "14",
            "FizzBuzz"
        ]

        URL: https://leetcode.com/problems/fizz-buzz/description/
    */
    public IList<string> Solution(int n)
    {
        var result = new List<string>();

        string output = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            
            if(i % 3 == 0)
                output = "Fizz";
            if(i % 5 == 0)
                output += "Buzz";
            if(output == string.Empty)
                output = i.ToString();

            result.Add(output);

            output = string.Empty;
        }

        return result;
    }
}