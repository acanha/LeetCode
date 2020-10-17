/*
    Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    Return the array in the form [x1,y1,x2,y2,...,xn,yn].
 */

public class Problem1470
{
    public int[] Solution(int[] nums, int n)
    {
        var result = new int[2 * n];
        var index = 0;

        for (int i = 0; i < n; i++)
        {
            result[index] = nums[i];
            index++;
            result[index] = nums[i + n];
            index++;
        }

        return result;
    }
}

