using System.Linq;

public class Problem1662
{
    public bool Solution(string[] word1, string[] word2)
    {
        var firstWord = word1.Aggregate((actual, next) => actual + next);
        var secondWord = word2.Aggregate((actual, next) => actual + next);
        return firstWord.Equals(secondWord);
    }
}

