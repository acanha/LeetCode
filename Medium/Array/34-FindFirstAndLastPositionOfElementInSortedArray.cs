/*
    Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

    If target is not found in the array, return [-1, -1].

    You must write an algorithm with O(log n) runtime complexity.
 */

using System.Linq;

public class Problem34
{
    public int[] Solution(int[] nums, int target)
    {
        var result = new int[2] { -1, -1 };

        if(nums.Length == 0) 
            return result;

        if (nums.Length == 1 && nums[0] == target)
            return [0, 0];

        for (int startIndex = 0; startIndex <= nums.Length / 2; startIndex++)
        {
            var endIndex = nums.Length - (startIndex + 1);

            var start = nums[startIndex];
            var end = nums[endIndex];

            if (start == target)
            {
                if (result[0] == -1)
                {
                    result[0] = startIndex;
                    result[1] = startIndex;
                }
                else if (result[0] == result[1])
                {
                    if (result[0] > startIndex)
                        result[0] = startIndex;
                    else
                        result[1] = startIndex;
                }
                else
                {
                    if (result[1] < startIndex)
                        result[1] = startIndex;
                }
            }

            if (end == target)
            {
                if (result[1] == -1)
                {
                    result[0] = endIndex;
                    result[1] = endIndex;
                }
                else if (result[0] == result[1])
                {
                    if(result[0] > endIndex)
                        result[0] = endIndex;
                    else
                        result[1] = endIndex;
                }
                else
                {
                    if (result[1] < endIndex)
                        result[1] = endIndex;

                    if (result[0] > endIndex)
                        result[0] = endIndex;
                }
            }

        }

        return result;
    }

    public int[] Solution2(int[] nums, int target)
    {
        return [GetStartIndex(nums, target), GetEndIndex(nums, target)];
    }

    private int GetStartIndex(int[] nums, int target)
    {
        return nums.ToList().IndexOf(target);
    }

    private int GetEndIndex(int[] nums, int target)
    {
        return nums.ToList().LastIndexOf(target);
    }
}

