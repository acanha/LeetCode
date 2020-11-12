/*
    Balanced strings are those who have equal quantity of 'L' and 'R' characters.

    Given a balanced string s split it in the maximum amount of balanced strings.

    Return the maximum amount of splitted balanced strings.
 */

public class Problem1221
{
    public int Solution(string s)
    {
        var total = 0;
        var characterL = 'L';
        var characterR = 'R';
        var countL = 0;
        var countR = 0;

        foreach (var character in s)
        {
            if (character == characterL)
            {
                countL++;
                IsBalancedString(ref countL, ref countR, ref total);
            }
            else if(character == characterR)
            {
                countR++;
                IsBalancedString(ref countL, ref countR, ref total);
            }
        }

        return total;
    }

    public void IsBalancedString(ref int countL, ref int countR, ref int total)
    {
        if (countR > 0 && countL > 0 && countL == countR)
        {
            countR = 0;
            countL = 0;
            total++;
        }
    }
}

