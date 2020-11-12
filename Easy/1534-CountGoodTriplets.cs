using System;

/*
    Given an array of integers arr, and three integers a, b and c. You need to find the number of good triplets.

    A triplet (arr[i], arr[j], arr[k]) is good if the following conditions are true:

    0 <= i < j < k < arr.length
    |arr[i] - arr[j]| <= a
    |arr[j] - arr[k]| <= b
    |arr[i] - arr[k]| <= c
    Where |x| denotes the absolute value of x.

    Return the number of good triplets.
 */

public class Problem1534
{
    public int Solution(int[] arr, int a, int b, int c)
    {
        var result = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    var isTriplet = Math.Abs(arr[i] - arr[j]) <= a &&
                                    Math.Abs(arr[j] - arr[k]) <= b &&
                                    Math.Abs(arr[i] - arr[k]) <= c;

                    result = isTriplet ? result + 1 : result;
                }
            }
        }

        return result;
    }
}

