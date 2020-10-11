using System.Collections;

public class Problem461
{
    /*
        The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        Given two integers x and y, calculate the Hamming distance.

        Note:
        0 ≤ x, y < 2^31.
        
        Example:

        Input: x = 1, y = 4

        Output: 2

        Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
               ↑   ↑
        The above arrows point to positions where the corresponding bits are different.
        URL: https://leetcode.com/problems/hamming-distance/description/
     */
    public int Solution(int x ,int y)
    {
        int hammingDistance = 0;

        var xBitArray = new BitArray(new int[]{ x });
        var yBitArray = new BitArray(new int[]{ y });

        for (int i = 0; i < xBitArray.Count; i++)
        {
            hammingDistance = xBitArray[i] ^ yBitArray[i] ? hammingDistance + 1 : hammingDistance;
        }

        return hammingDistance;
    }
}