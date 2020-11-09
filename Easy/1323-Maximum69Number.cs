using System;
using System.Collections.Generic;
using System.Text;

/*
    Given a positive integer num consisting only of digits 6 and 9.

    Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).
 */

public class Problem1323
{
    public int Solution(int num)
    {
        var numberInString = num.ToString();
        var firstSixIndex = numberInString.IndexOf('6');
        return int.Parse($"{numberInString.Substring(0, firstSixIndex + 1).Replace('6', '9')}{numberInString.Substring(firstSixIndex + 1)}");
    }
}

