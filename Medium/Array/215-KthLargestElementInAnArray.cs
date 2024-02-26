/*
    Given an integer array nums and an integer k, return the kth largest element in the array.

    Note that it is the kth largest element in the sorted order, not the kth distinct element.

    Can you solve it without sorting?
 */
using System.Diagnostics;
using System.Linq;

public class Problem215
{
    public int Solution(int[] nums, int k)
    {
        return nums.ToList()
                   .OrderDescending()
                   .ElementAt(k - 1);
        
    }

    public int Solution2(int[] nums, int k)
    {
        var list = nums.ToList();

        for (int i = 0; i < k - 1; i++)
        {
            list.Remove(list.Max());
        }

        return list.Max();
    }
}

