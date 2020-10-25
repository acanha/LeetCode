using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;

/*
    Given an integer number n, return the difference between the product of its digits and the sum of its digits.
 */
public class Problem1281
{
    public int Solution(int n)
    {
        var product = 1;
        var sum = 0;

        while (n > 0)
        {
            var number = n % 10;
            product = product * number;
            sum = sum + number;
            n = n / 10;
        }
        
        return product - sum;
    }
}


