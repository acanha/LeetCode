using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Given an array of positive integers arr, calculate the sum of all possible odd-length subarrays.

    A subarray is a contiguous subsequence of the array.

    Return the sum of all odd-length subarrays of arr.
 */

public class Problem1588
{
    public int Solution(int[] arr)
    {
        var sum = 0;

        for (int i = 1; i <= arr.Length; i++)
        {
            var arrayCopy = arr.ToList();

            if(i % 2 == 1)
            {
                while (i <= arrayCopy.Count())
                {
                    var arrayElements = arrayCopy.Take(i);
                    sum += arrayElements.Sum();
                    arrayCopy.RemoveAt(0);
                }
            }
        }

        return sum;
    }
}

