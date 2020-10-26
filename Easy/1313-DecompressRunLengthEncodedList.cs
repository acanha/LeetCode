using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    We are given a list nums of integers representing a list compressed with run-length encoding.
    Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0).
    For each such pair, there are freq elements with value val concatenated in a sublist.
    Concatenate all the sublists from left to right to generate the decompressed list.
    Return the decompressed list.
 */
public class Problem1313
{
    public int[] Solution(int[] nums)
    {
        var result = new List<int>();

        for (int i = 0; i < nums.Length / 2; i++)
        {
            var frequency = nums[2 * i]; 
            var value = nums[2 * i + 1];

            var sublist = Enumerable.Repeat(value, frequency).ToArray();
            result.AddRange(sublist);
        }

        return result.ToArray();
    }
}

