using System;

// Given an array nums of integers, return how many of them contain an even number of digits.

public class Problem1295
{
    public int Solution(int[] nums)
    {
        var result = 0;

        foreach (int number in nums)
        {
            var digits = Math.Floor(Math.Log10(number) + 1);

            if (digits % 2 == 0)
                result++;
        }

        return result;
    }
}

