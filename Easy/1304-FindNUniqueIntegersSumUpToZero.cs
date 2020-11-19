/*
    Given an integer n, return any array containing n unique integers such that they add up to 0.
 */
using System;
using System.Linq;

public class Problem1304 
{
    public int[] Solution(int n)
    {
        var result = new int[n];
        var random = new Random();
        var numbers = Enumerable.Range(1, n).ToList();

        var half = n / 2;

        for (int i = 0; i < half; i++)
        {
            var index = random.Next(numbers.Count());
            result[i] = numbers.ElementAt(index);
            result[half + i] = result[i] * -1;
            numbers.RemoveAt(index);
        }

        return result;
    }
}

