using System;
using System.Collections.Generic;
using System.Text;

/*
    Given a non-negative integer num, return the number of steps to reduce it to zero.
    If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
 */

public class Problem1342
{
    public int Solution(int num)
    {
        return NumberSteps(num, 0);
    }

    private bool IsEven(int number) => number % 2 == 0;

    private int NumberSteps(int number, int result)
    {
        if (number != 0)
        {
            result = IsEven(number) ? NumberSteps(number / 2, ++result) :NumberSteps(number - 1, ++result); 
        }

        return result;
    }
}

