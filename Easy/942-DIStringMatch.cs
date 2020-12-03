using System.Collections.Generic;
using System.Linq;

public class Problem942
{
    public int[] Solution(string S)
    {
        var result = new int[S.Length + 1];
        var list = new List<int>();

        for (int j = 0; j <= S.Length; j++)
        {
            list.Add(j);
        }

        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == 'I')
            {
                var min = list.Min();
                result[i] = min;
                list.Remove(min);
            }
            else
            {
                var max = list.Max();
                result[i] = max;
                list.Remove(max);
            }
        }

        result[S.Length] = list.First();

        return result;
    }
}

