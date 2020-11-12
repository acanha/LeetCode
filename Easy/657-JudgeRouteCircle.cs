using System.Collections.Generic;
using System.Linq;
public class Problem657
{
    /*
        Initially, there is a Robot at position (0, 0). 
        Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
        The move sequence is represented by a string. And each move is represent by a character. 
        The valid robot moves are R (Right), L (Left), U (Up) and D (down). 
        The output should be true or false representing whether the robot makes a circle.

        Example 1:
        
        Input: "UD"
        Output: true
        
        Example 2:
        Input: "LL"
        Output: false

        URL: https://leetcode.com/problems/judge-route-circle/description/
     */
    public bool Solution(string moves)
    {
        var position   = new int[2];
        var validMoves = new Dictionary<char, int>
        {
            {'R',  1},
            {'L', -1},
            {'U',  1},
            {'D', -1}
        };

        foreach (char move in moves)
        {
            if(move == 'R' || move == 'L')
            {
                position[0] += validMoves[move];
            }
            else if(move == 'U' || move == 'D')
            {
                position[1] += validMoves[move];
            }
        }

        return position.Sum() == 0;
    }
}