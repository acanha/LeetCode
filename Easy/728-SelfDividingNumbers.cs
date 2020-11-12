using System.Collections.Generic;
using System.Linq;
public class Problem728
{
    /*
        A self-dividing number is a number that is divisible by every digit it contains.

        For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

        Also, a self-dividing number is not allowed to contain the digit zero.

        Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

        Example 1:
        Input: 
        left = 1, right = 22

        Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
       
        Note:The boundaries of each input argument are 1 <= left <= right <= 10000.

        URL: https://leetcode.com/problems/self-dividing-numbers/description/
     */
    public IList<int> Solution(int left, int right)
    {
        var selfDividingNumbers = new List<int>();

        for (int number = left; number <= right; number++)
        {
            int[] numbers = number.ToString().ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();
            int count = 0;

            if(numbers.Contains(0))
                continue;

            foreach (int digit in numbers)
            {
                if(number % digit == 0) 
                    count++;
                else
                     break;
            }

            if(count == numbers.Count())
                selfDividingNumbers.Add(number);
            
        }

        return selfDividingNumbers;
    }
}