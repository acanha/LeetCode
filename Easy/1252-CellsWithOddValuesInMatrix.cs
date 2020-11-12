/*
    Given n and m which are the dimensions of a matrix initialized by zeros and given an array indices where indices[i] = [ri, ci].
    For each pair of [ri, ci] you have to increment all cells in row ri and column ci by 1.

    Return the number of cells with odd values in the matrix after applying the increment to all indices.
 */

public class Problem1252
{
    public int Solution(int n, int m, int[][] indices)
    {
        int[,] matrix = new int[n, m];
        var result = 0;

        for (int i = 0; i < indices.Length; i++)
        {
            var pair = indices[i];
            var row = pair[0];
            var column = pair[1];

            for (int j = 0; j < m ; j++)
            {
                matrix[row, j] = matrix[row, j] + 1;
            }

            for (int k = 0; k < n; k++)
            {
                matrix[k, column] = matrix[k, column] + 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(matrix[i, j] % 2 != 0)
                    result++;
            }

        }

        return result;
    }
}

