/*
    You are given an array prices where prices[i] is the price of a given stock on the ith day.

    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */


public class Problem121
{
    public int Solution(int[] prices)
    {
        var maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                var difference = prices[i] - prices[j];
                if (difference > maxProfit)
                {
                    maxProfit = difference;
                }
            }
        }

        return maxProfit;
    }

    public int Solution2(int[] prices)
    {
        var maxProfit = 0;
        var leftIndex = 0;
        var rightIndex = 1;

        while (rightIndex < prices.Length)
        {
            var left = prices[rightIndex];
            var right = prices[leftIndex];

            if(right > left)
            {
                var profit = right - left;
                if(profit > maxProfit)
                    maxProfit = profit;
            }
            else
            {
                leftIndex = rightIndex;
            }

            rightIndex++;
        }
        

        return maxProfit;
    }
}

