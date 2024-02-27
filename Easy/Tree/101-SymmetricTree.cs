/*
    Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
 */
using System.Collections.Generic;
using System.Linq;

public class Problem101
{
    private List<int> LeftSide = new List<int>();
    private List<int> RightSide = new List<int>();

    public bool Solution(TreeNode root)
    {
        if (root.left != null)
        {
            LeftSide.Add(root.left.val);
            GetLeftSide(root.left);
        }

        if (root.right != null)
        {
            RightSide.Add(root.right.val);
            GetRightSide(root.right);
        }

        return LeftSide.SequenceEqual(RightSide);
    }

    private List<int> GetLeftSide(TreeNode root)
    {
        if (root.left != null)
        {
            LeftSide.Add(root.left.val);
            GetLeftSide(root.left);
        }
        else
        {
            LeftSide.Add(0);
        }

        if (root.right != null)
        {
            LeftSide.Add(root.right.val);
            GetLeftSide(root.right);
        }
        else
        {
            LeftSide.Add(0);
        }

        return LeftSide;
    }

    private List<int> GetRightSide(TreeNode root)
    {
        if (root.right != null)
        {
            RightSide.Add(root.right.val);
            GetRightSide(root.right);
        }
        else
        {
            RightSide.Add(0);
        }

        if (root.left != null)
        {
            RightSide.Add(root.left.val);
            GetRightSide(root.left);
        }
        else
        {
            RightSide.Add(0);
        }

        return RightSide;
    }
}