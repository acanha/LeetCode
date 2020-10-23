using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Given a string s and an integer array indices of the same length.
    The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
    Return the shuffled string.
 */

public class Problem1528
{
    public string Solution(string s, int[] indices)
    {
        char[] result = new char[indices.Length];
        char[] stringToShuffle = s.ToArray();

        for (int i = 0; i < indices.Length; i++)
        {
            var index = Array.IndexOf(indices, i);
            result[i] = stringToShuffle[index];
        }

        return new string(result);
    }
}

