using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  
    Each character in S is a type of stone you have. 
    You want to know how many of the stones you have are also jewels.
    The letters in J are guaranteed distinct, and all characters in J and S are letters.
    Letters are case sensitive, so "a" is considered a different type of stone from "A".
 */

public class Problem771
{
    public int Solution(string J, string S)
    {
        int result = 0;

        foreach (char jewel in J)
        {
            result += S.Where(stone => stone == jewel).Count();
        }

        return result;
    }
}

