using System;
using System.Collections.Generic;
using System.Text;

/*
    Given the array prices where prices[i] is the price of the ith item in a shop. 
    There is a special discount for items in the shop, if you buy the ith item, 
    then you will receive a discount equivalent to prices[j] where j is the minimum index such that j > i and prices[j] <= prices[i], 
    otherwise, you will not receive any discount at all.

    Return an array where the ith element is the final price you will pay for the ith item of the shop considering the special discount.
 
 */

public class Problem1475
{
    public int[] Solution(int[] prices)
    {
        var discounts = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            discounts[i] = prices[i];

            for (int j = i + 1; j < prices.Length; j++)
            {
                var itemPrice = prices[i];
                var nextLowerPrice = prices[j];

                if(nextLowerPrice <= itemPrice)
                {
                    discounts[i] = itemPrice - nextLowerPrice;
                    break;
                }
            }
        }

        return discounts;
    }
}

