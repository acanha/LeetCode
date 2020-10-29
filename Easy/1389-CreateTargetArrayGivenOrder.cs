using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

/*
    Given two arrays of integers nums and index. Your task is to create target array under the following rules:

    Initially target array is empty.
    From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
    Repeat the previous step until there are no elements to read in nums and index.
    Return the target array.

    It is guaranteed that the insertion operations will be valid.
 */

public class Problem1389
{
    public int[] Solution(int[] nums, int[] index)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var arrayIndex = index[i];
            var number = nums[i];
            result = MoveRight(result, arrayIndex + 1);
            result[arrayIndex] = number;
        }

        return result;
    }

    private int[] MoveRight(int[] current, int index)
    {
        var result = new int[current.Length];
        Array.Copy(current,result, current.Length);

        for (int i = index; i < current.Length; i++)
        {
            result[i] = current[i - 1];
        }

        return result;
    }
}

