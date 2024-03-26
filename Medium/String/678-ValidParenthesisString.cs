using System;

namespace LeetCode.Medium.String;
/*
    Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.

    The following rules define a valid string:

    Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    Any right parenthesis ')' must have a corresponding left parenthesis '('.
    Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".
 
 */
public class Problem678
{
    public bool Solution(string s)
    {
        if(s.Length == 1)
            return false;

        var isValidString = false;
        int leftBracket = 0;
        int rightBracket = 0;
        int wildcard = 0;

        foreach (var item in s)
        {
            if(item == '(')
            {
                leftBracket++;
            }
            else if(item == ')')
            {
                rightBracket++;
            }
            else if (item == '*')
            {
                wildcard++;
            }
        }

        if(leftBracket == rightBracket)
        {
            isValidString = true;
        }
        else
        { 
            if(leftBracket < rightBracket)
            {
                var diff = rightBracket - leftBracket;
                if(wildcard >= diff )
                {
                    isValidString = true;
                }
            }
            else
            {
                var diff = leftBracket - rightBracket;
                if (wildcard >= diff)
                {
                    isValidString = true;
                }
            }
        }

        return isValidString;
    }

    public bool Solution2(string s)
    {
        // Solution based on leetcode solution:
        // https://leetcode.com/problems/valid-parenthesis-string/solutions/543521/java-count-open-parenthesis-o-n-time-o-1-space-picture-explain
        int cmin = 0;
        int cmax = 0; // open parentheses count in range [cmin, cmax]

        foreach (var c in s)
        {
            if (c == '(')
            {
                cmax++;
                cmin++;
            }
            else if (c == ')')
            {
                cmax--;
                cmin--;
            }
            else if (c == '*')
            {
                cmax++; // if `*` become `(` then openCount++
                cmin--; // if `*` become `)` then openCount--
                // if `*` become `` then nothing happens
                // So openCount will be in new range [cmin-1, cmax+1]
            }
            if (cmax < 0) return false; // Currently, don't have enough open parentheses to match close parentheses-> Invalid
                                        // For example: ())(
            cmin = Math.Max(cmin, 0);   // It's invalid if open parentheses count < 0 that's why cmin can't be negative
        }

        return cmin == 0; // Return true if can found `openCount == 0` in range [cmin, cmax]
    }
}
