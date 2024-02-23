/*
    TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns 
    a short URL such as http://tinyurl.com/4e9iAk. Design a class to encode a URL and decode a tiny URL.

    There is no restriction on how your encode/decode algorithm should work. 
    You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
 
 */
using System;
using System.Collections;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;

public class Problem535
{
    private Hashtable hashtable = new Hashtable();
    private string Alphanumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        var encodedBuilder = new StringBuilder();
        var random = new Random();
        string encoded;

        do
        {
            for (int i = 0; i < 5; i++)
            {
                var index = random.Next(61);
                encodedBuilder.Append(Alphanumeric.ElementAt(index));
            }

            encoded = encodedBuilder.ToString();
        } while (hashtable.ContainsKey(encoded));

        hashtable.Add(encoded,longUrl);

        return encoded;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return (string)hashtable[shortUrl];
       
    }
}
// Your Codec object will be instantiated and called as such:
// var codec = new Problem535();
// codec.decode(codec.encode(url));

