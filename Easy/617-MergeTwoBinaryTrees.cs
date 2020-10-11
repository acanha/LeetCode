using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Problem617
{
    /*
        Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.

        You need to merge them into a new binary tree. 
        The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. 
        Otherwise, the NOT null node will be used as the node of new tree.

        Example 1:
        Input: 
            Tree 1                     Tree 2                  
                1                         2                             
               / \                       / \                            
              3   2                     1   3                        
             /                           \   \                      
            5                             4   7                  
        Output: 
        Merged tree:
                 3
                / \
               4   5
              / \   \ 
             5   4   7

        Note: The merging process must start from the root nodes of both trees.

        URL: https://leetcode.com/problems/merge-two-binary-trees/description/
    */
    public TreeNode Solution(TreeNode t1, TreeNode t2)
    {
        var mergedTree = MergeTree(t1,t2);

        return mergedTree;
    }

    public TreeNode MergeTree(TreeNode t1, TreeNode t2)
    {
        int? left = null;
        left = t1 != null ? t1.val : left;
        
        int? right = null;
        right = t2 != null ? t2.val : right;

        int? root = null;

        if(left.HasValue && right.HasValue)
            root = left.Value + right.Value;
        else if(left.HasValue)
            root = left.Value;
        else if(right.HasValue)
            root = right.Value;

        TreeNode mergedTree = root.HasValue ? new TreeNode(root.Value) : null;

        if(mergedTree != null)
        {
            TreeNode treeOneLeft  = null;
            TreeNode treeTwoLeft  = null;
            TreeNode treeOneRight = null;
            TreeNode treeTwoRight = null;

            if(t1 != null)
            {
                treeOneLeft  = t1.left;
                treeOneRight = t1.right;
            }

            if(t2 != null)
            {
                treeTwoLeft  = t2.left;
                treeTwoRight = t2.right;
            }

            mergedTree.left  = MergeTree(treeOneLeft, treeTwoLeft);
            mergedTree.right = MergeTree(treeOneRight, treeTwoRight);
        }

        return mergedTree;
    }
}

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
