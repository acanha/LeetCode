/*
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    typically using all the original letters exactly once.
 */
using System.Linq;

public class Problem242
{
    public bool Solution(string s, string t)
    {
        var firstStringOrdered = s.Order();
        var secondStringOrdered = t.Order();

        return firstStringOrdered.SequenceEqual(secondStringOrdered);
    }
}

