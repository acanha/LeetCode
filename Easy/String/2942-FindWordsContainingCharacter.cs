/*
    You are given a 0-indexed array of strings words and a character x.

    Return an array of indices representing the words that contain the character x.
 
 */

using System.Collections.Generic;
using System.Linq;

public class Problem2942
{
    public IList<int> Solution(string[] words, char x)
    {
        var result = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
