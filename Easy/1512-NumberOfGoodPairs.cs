using System;
using System.Collections.Generic;
using System.Text;

/*
    Given an array of integers nums.
    A pair (i,j) is called good if nums[i] == nums[j] and i < j.
    Return the number of good pairs.
 
 */
public class Problem1512
{
    public int Solution(int[] nums)
    {
        var numberOfGoodPairs = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    numberOfGoodPairs++;

            }
        }

        return numberOfGoodPairs;
    }
}

