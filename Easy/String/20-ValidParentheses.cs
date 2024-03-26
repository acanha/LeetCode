using System.Collections;
using System.Collections.Generic;

/*
    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.
 */

public class Problem20
{
    public bool Solution(string input)
    {
        var isValid = true;
        var brackets = new Dictionary<string, int>
        {
            { "round", 0 },   // ()
            { "square", 0 },  // []
            { "curly", 0}     // {}
        };

        foreach (var bracket in input) 
        {
            if (bracket == '(')
                brackets["round"] += 1;
            else if (bracket == ')')
                brackets["round"] -= 1;
            else if (bracket == '[')
                brackets["square"] += 1;
            else if (bracket == ']')
                brackets["square"] -= 1;
            else if (bracket == '{')
                brackets["curly"] += 1;
            else if (bracket == '}')
                brackets["curly"] -= 1;

            if (brackets["round"] < 0 || brackets["square"] < 0 || brackets["curly"] < 0 )
                return false;

        }

        if (brackets["round"] != 0 || brackets["square"] != 0 || brackets["curly"] != 0)
            isValid = false;

        return isValid;
    }

    public bool Solution2(string input)
    {
        // Solution based on leetcode solution
        // https://leetcode.com/problems/valid-parentheses/solutions/3399077/easy-solutions-in-java-python-and-c-look-at-once-with-exaplanation
        
        // Initialize an empty stack.
        var stack = new Stack<char>();
        var matchBrackets = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        // Traverse the input string character by character.
        foreach (var bracket in input)
        {
            // If the current character is an opening bracket (i.e., '(', '{', '['), push it onto the stack.
            if (bracket == '(' || bracket == '[' || bracket == '{' )
                stack.Push(bracket);

            // If the current character is a closing bracket (i.e., ')', '}', ']'), check if the stack is empty.
            // If it is empty, return false, because the closing bracket does not have a corresponding opening bracket.
            // Otherwise, pop the top element from the stack and check if it matches the current closing bracket.
            // If it does not match, return false, because the brackets are not valid.
            if (bracket == ')' || bracket == ']' || bracket == '}')
            {
                if (stack.Count == 0)
                    return false;

                var lastBracket = stack.Pop();

                if (matchBrackets[lastBracket] != bracket)
                    return false;
            }
        }
        // After traversing the entire input string, if the stack is empty, return true,
        // because all opening brackets have been matched with their corresponding closing brackets.
        // Otherwise, return false, because some opening brackets have not been matched with their corresponding closing brackets.
        return stack.Count == 0;
    }
}