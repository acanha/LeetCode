using System;
using System.Collections.Generic;
using System.Text;

/*
    Given an integer n and an integer start.

    Define an array nums where nums[i] = start + 2*i (0-indexed) and n == nums.length.

    Return the bitwise XOR of all elements of nums.
 
 */

public class Problem1486
{
    public int Solution(int n, int start)
    {
        int[] resultArray = new int[n];
        int result = 0;

        for (int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = start + 2 * i;
            result ^= resultArray[i];
        }

        return result;
    }
}

