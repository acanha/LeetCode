/*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice. 

     You can return the answer in any order.
     
 */
using System.Collections.Generic;

public class Problem1
{
    public int[] Solution(int[] nums, int target)
    {
        var indices = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices.Add(i);
                    indices.Add(j);
                    break;
                }
            
            }

            if (indices.Count != 0)
                break;
        }

        return indices.ToArray();
    }
}

