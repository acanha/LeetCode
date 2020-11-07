using System;
using System.Collections.Generic;
using System.Text;

/*
    Given a square matrix mat, return the sum of the matrix diagonals.

    Only include the sum of all the elements on the primary diagonal and 
    all the elements on the secondary diagonal that are not part of the primary diagonal.
    
    Rational:

    00 01 02 03 04
    10 11 12 13 14
    20 21 22 23 24
    30 31 32 33 34
    40 41 42 43 44

    The primary diagonal is: 00  11  22  33  44
    The secondary diagonal is : 04  13  22  31  40

    We can use two variables i,j and increment i until the lenght of the matrix while decrementing j.

 */

public class Problem1572
{
    public int Solution(int[][] mat)
    {
        var length = mat.Length;
        var sum = 0;
        int j = length - 1;

        for (int i = 0; i < length; i++)
        {
            sum += mat[i][i];
            sum += i != j ? mat[i][j] : 0;

            j--;
        }

        return sum;
    }
}

