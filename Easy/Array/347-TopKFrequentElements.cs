/*
    Given an integer array nums and an integer k, return the k most frequent elements. 
    You may return the answer in any order.
 */
using System.Collections.Generic;
using System.Linq;

public class Problem347
{
    public int[] Solution(int[] nums, int k)
    {
        var mostFrequentElements = new Dictionary<int, int>();

        foreach (var element in nums)
        {
            mostFrequentElements[element] = mostFrequentElements.ContainsKey(element)
                                            ? mostFrequentElements[element] += 1
                                            : 1;
        }

        return mostFrequentElements.OrderByDescending(x => x.Value)
                                   .Take(k)
                                   .Select(x => x.Key)
                                   .ToArray();
    }
}