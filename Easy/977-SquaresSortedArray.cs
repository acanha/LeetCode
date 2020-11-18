/*
    Given an array of integers A sorted in non-decreasing order, 
    return an array of the squares of each number, also in sorted non-decreasing order.
 */
using System;
using System.Linq;

public class Problem977
{
    public int[] Solution(int[] A)
    {
        var result = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            result[i] =(int)Math.Pow(A[i], 2);
        }

        return result.OrderBy(number => number).ToArray();
    }
}

