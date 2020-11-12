using System.Linq;

/*
    Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
    That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
    Return the answer in an array.
 */

public class Problem1365
{
    public int[] Solution(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var number = nums.ToList().ElementAt(i);
            var smallerThanNumberCount = nums.Where(x => x != number && x < number).Count();
            result[i] = smallerThanNumberCount;
        }

        return result;
    }
}

