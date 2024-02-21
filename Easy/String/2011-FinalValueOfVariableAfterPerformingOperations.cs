/*
    There is a programming language with only four operations and one variable X:

    ++X and X++ increments the value of the variable X by 1.
    --X and X-- decrements the value of the variable X by 1.
    Initially, the value of X is 0.

    Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.
 
 
 */

using System.Linq;

public class Problem2011
{
    public int Solution(string[] operations)
    {
        var result = 0;

        foreach (var operation in operations)
        {
            if (operation.Equals("++X", System.StringComparison.OrdinalIgnoreCase) || 
                operation.Equals("X++", System.StringComparison.OrdinalIgnoreCase))
            {
                result++;
            }

            if (operation.Equals("--X", System.StringComparison.OrdinalIgnoreCase) ||
                operation.Equals("X--", System.StringComparison.OrdinalIgnoreCase))
            {
                result--;
            }
        }

        return result;
    }
}