using System.Collections.Generic;
using System.Linq;
public class Problem500
{
    /*
        Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.

        American keyboard 
        QWERTYUIOP
        ASDFGHJKL
        ZXCVBNM

        Example 1:
        Input: ["Hello", "Alaska", "Dad", "Peace"]
        Output: ["Alaska", "Dad"]

        Note:
        You may use one character in the keyboard more than once.
        You may assume the input string will only contain letters of alphabet.

        URL: https://leetcode.com/problems/keyboard-row/description/
    */
    public string[] Solution(string[] words)
    {
        var wordsTypedSameRow = new List<string>();

        char[] firstRow  = new char[]{'Q','W','E','R','T','Y','U','I','O','P'};
        char[] secondRow = new char[]{'A','S','D','F','G','H','J','K','L'};
        char[] thirdRow  = new char[]{'Z','X','C','V','B','N','M'};

        foreach (string word in words)
        {
            var distinctLetters = word.ToUpper().Distinct();

            var firstRowIntersect  = distinctLetters.Intersect(firstRow);
            var secondRowIntersect = distinctLetters.Intersect(secondRow);
            var thirdRowIntersect  = distinctLetters.Intersect(thirdRow);

            int distinctCount = distinctLetters.Count();

            if(distinctCount == firstRowIntersect.Count() || distinctCount == secondRowIntersect.Count() || distinctCount == thirdRowIntersect.Count())
                wordsTypedSameRow.Add(word);
            
        }

        return wordsTypedSameRow.ToArray();
    }
}

