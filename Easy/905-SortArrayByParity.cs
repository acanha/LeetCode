/*
    Given an array A of non-negative integers, return an array consisting of all the even elements of A, 
    followed by all the odd elements of A.

    You may return any answer array that satisfies this condition.
 */

using System.Linq;

public class Problem905
{
    public int[] Solution(int[] A)
    {
        var evenNumbers = A.Where(number => number % 2 == 0);
        var oddNumbers = A.Where(number => number % 2 != 0);

        return evenNumbers.Concat(oddNumbers).ToArray();
    }
}

