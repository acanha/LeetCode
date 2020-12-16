using System.Linq;

public class Problem1684
{
    public int Solution(string allowed, string[] words)
    {
        int result = 0;
        var characters = allowed.Select(c => c.ToString());

        foreach (var word in words)
        {
            var w = word;
            foreach (var charecter in characters)
            {
                w = w.Replace(charecter, string.Empty);
            }

            result = w.Length > 0 ? result : ++result;
        }

        return result;
    }
}

