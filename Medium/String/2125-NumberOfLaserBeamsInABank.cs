/*
    Anti-theft security devices are activated inside a bank. 
    You are given a 0-indexed binary string array bank representing the floor plan of the bank, which is an m x n 2D matrix. 
    bank[i] represents the ith row, consisting of '0's and '1's. 
    '0' means the cell is empty, while'1' means the cell has a security device.

    There is one laser beam between any two security devices if both conditions are met:

    The two devices are located on two different rows: r1 and r2, where r1 < r2.
    For each row i where r1 < i < r2, there are no security devices in the ith row.
    Laser beams are independent, i.e., one beam does not interfere nor join with another.

    Return the total number of laser beams in the bank.
 */
using System.Linq;

public class Problem2125 
{
    public int Solution(string[] bank)
    {
        var result = 0;
        var securityDevicesPerRow = 0;

        for (int i = 0; i < bank.Length; i++)
        {
            var totalDevices = bank[i].Count(x => x.Equals('1'));

            if (securityDevicesPerRow == 0)
            {
                securityDevicesPerRow = totalDevices;
            }
            else
            {
                if(totalDevices == 0)
                {
                    continue;
                }

                result += securityDevicesPerRow * totalDevices;

                securityDevicesPerRow = totalDevices;
            }
        }

        return result;
    }

}
