/*
    Given the array of integers nums, you will choose two different indices i and j of that array. 
    Return the maximum value of (nums[i]-1)*(nums[j]-1).
 */
using System.Linq;

public class Problem1464
{
    public int Solution(int[] nums)
    {
        var lastTwo = nums.OrderBy(number => number)
                          .TakeLast(2)
                          .ToArray();

        return (lastTwo[0] - 1) * (lastTwo[1] - 1);

    }
}

