/*
    In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.

    Return the element repeated N times.
 */

using System.Linq;

public class Problem961
{
    public int Solution(int[] A)
    {
        return A.GroupBy(number => number)
                .First(number => number.Count() == A.Length / 2)
                .Key;
    }
}

