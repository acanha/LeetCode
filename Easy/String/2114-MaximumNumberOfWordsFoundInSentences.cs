﻿/*
    A sentence is a list of words that are separated by a single space with no leading or trailing spaces.

    You are given an array of strings sentences, where each sentences[i] represents a single sentence.

    Return the maximum number of words that appear in a single sentence.
 */

public class Problem2114
{
    public int Solution(string[] sentences)
    {
        var result = 0;

        foreach (var sentence in sentences)
        {
            var lenght = sentence.Split(' ').Length;
            result = lenght > result ? lenght : result;
        }

        return result;
    }
}
