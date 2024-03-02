/*
    Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */

using System.Collections.Generic;
using System.Linq;

public class Problem217
{
    public bool Solution(int[] nums)
    {
        return nums.Distinct().Count() != nums.Length;
    }

    public bool SolutionWithoutLinq(int[] nums)
    {
        var distinct = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (distinct.Contains(nums[i]))
            {
                return true;
            }

            distinct.Add(nums[i]);
        }

        return false;
    }

    public bool SolutionHash(int[] nums)
    {
        var distinct = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (distinct.Contains(nums[i]))
            {
                return true;
            }

            distinct.Add(nums[i]);
        }

        return false;
    }
}

