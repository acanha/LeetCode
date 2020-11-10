using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

    For convenience, the full table for the 26 letters of the English alphabet is given below:

    [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. For example, "cab" can be written as "-.-..--...", (which is the concatenation "-.-." + ".-" + "-..."). We'll call such a concatenation, the transformation of a word.

    Return the number of different transformations among all words we have.
 
 */

public class Problem804
{
    public int Solution(string[] words)
    {
        var morse = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            morse[i] = ConvertToMorse(words[i]);
        }

        return morse.GroupBy(transformation => transformation).Count();
    }

    private string ConvertToMorse(string word)
    {
        var stringBuilder = new StringBuilder();

        foreach (var character in word)
        {
            stringBuilder.Append(LetterToMorse[character]);
        }

        return stringBuilder.ToString();
    }

    private Dictionary<char, string> LetterToMorse = new Dictionary<char, string> 
    {
        { 'a', ".-"},
        { 'b', "-..."},
        { 'c', "-.-."},
        { 'd', "-.."},
        { 'e', "."},
        { 'f', "..-."},
        { 'g', "--."},
        { 'h', "...."},
        { 'i', ".."},
        { 'j', ".---"},
        { 'k', "-.-"},
        { 'l', ".-.."},
        { 'm', "--"},
        { 'n', "-."},
        { 'o', "---"},
        { 'p', ".--."},
        { 'q', "--.-"},
        { 'r', ".-."},
        { 's', "..."},
        { 't', "-"},
        { 'u', "..-"},
        { 'v', "...-"},
        { 'w', ".--"},
        { 'x', "-..-"},
        { 'y', "-.--"},
        { 'z', "--.."},
    };
}

