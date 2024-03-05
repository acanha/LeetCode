/*
    Given an array of strings strs, group the anagrams together. You can return the answer in any order.

    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    typically using all the original letters exactly once.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Problem49
{
    public IList<IList<string>> Solution(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            var value = string.Concat(str.Order());

            if (anagrams.ContainsKey(value))
            {
                var list = new List<string>();
                anagrams.TryGetValue(value, out list);
                list.Add(str);
            }
            else
            {
                anagrams.Add(value, new List<string> { str });
            }
        }
        return anagrams.Values.Cast<IList<string>>().ToList();
    }

    public IList<IList<string>> Solution2(string[] strs)
    {
        var result = new List<List<string>>();

        var anagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            var value = string.Concat(str.Order());

            if (anagrams.ContainsKey(value))
            {
                var list = new List<string>();
                anagrams.TryGetValue(value, out list);
                list.Add(str);
            }
            else
            {
                anagrams.Add(value, new List<string> { str });
            }
        }

        result = anagrams.GroupBy(x => x.Key, x => x.Value)
                         .Select(x => x.ToList())
                         .SelectMany(x => x)
                         .ToList();

        return (IList<IList<string>>)result;
    }

    public IList<IList<string>> Solution3(string[] strs)
    {
        var charA = (int)'a';
        var hash = new Hashtable();
        var alphabet = new int[26];

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            Array.Clear(alphabet);

            foreach (var chart in str)
            {
                /*
                 * Since we have all lowercase strings we can get the ASCII code for each character and subtract the 'a' to give an index from 0 to 25.
                 * 
                 * character 'a' ASCII code => 97
                 * character 'b' ASCII code => 98
                 * 
                 * 'a' - 'a' => 97 - 97 => index 0
                 * 'b' - 'a' => 98 - 97 => index 1
                 * 
                 *
                 */
                var index = chart - charA;
                alphabet[index] += 1;
            }
            /*
             * Convert the array with the number of characters into a key.
             * e.g: 10001000000000000001000000
             *      a...e..............t......
             *
             * Every anagram with one character 'a', one character 'e' and one character 't' will have the same key
             *
             */
            var key = alphabet.Select(x => x.ToString()).Aggregate((x, i) => x + i);

            if (hash.ContainsKey(key))
            {
                var list = hash[key] as List<string>;
                list.Add(str);
                hash[key] = list;
            }
            else
            {
                hash[key] = new List<string> { str };
            }
        }

        var result = hash.Values.Cast<List<string>>();
        return result.Cast<IList<string>>().ToList();
    }
}

