/*
    A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
    it reads the same forward and backward. Alphanumeric characters include letters and numbers.

    Given a string s, return true if it is a palindrome, or false otherwise.
 */

using System.Text;

public class Problem125
{
    public bool Solution(string s)
    {
        var isPalindrome = true;

        var builder = new StringBuilder();

        foreach (var word in s)
        {
            if (char.IsAsciiLetterOrDigit(word))
            {
                builder.Append(char.ToLower(word));
            }
        }

        var cleaned = builder.ToString();
        var middle = cleaned.Length / 2;

        if(cleaned.Length == 1)
        {
            return false;
        }

        for (int i = 0; i < middle; i++)
        {
            if(cleaned[i] != cleaned[cleaned.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}

