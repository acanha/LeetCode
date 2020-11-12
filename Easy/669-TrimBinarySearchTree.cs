public class Problem669
{
    /*
        Given a binary search tree and the lowest and highest boundaries as L and R, trim the tree so that all its elements lies in [L, R] (R >= L). 
        You might need to change the root of the tree, so the result should return the new root of the trimmed binary search tree.

        Example 1:
        Input: 
            1
           / \
          0   2

        L = 1
        R = 2

        Output: 
            1
             \
              2

        Example 2:
        Input: 
            3
           / \
          0   4
           \
            2
           /
          1

        L = 1
        R = 3

        Output: 
            3
           / 
          2   
         /
        1

        URL:https://leetcode.com/problems/trim-a-binary-search-tree/description/
    */
    public TreeNode Solution(TreeNode root, int L,int R)
    {
        TreeNode newNode = null;

        if(root != null)
        {
            if(root.val >= L && root.val <= R)
                newNode = new TreeNode(root.val);

            if(newNode != null)
            {
                newNode.left  = Solution(root.left, L, R);
                newNode.right = Solution(root.right, L, R);
            } 
            else if(root.val < L && root.right != null)
            {
                newNode = new TreeNode(root.right.val);
                newNode.left  = Solution(root.right.left, L, R);
                newNode.right = Solution(root.right.right, L, R);
                
                if (newNode.val < L || newNode.val > R)
                {
                    if (newNode.left == null && newNode.right == null)
                        newNode = null;
                    else if (newNode.left != null && newNode.right == null)
                        newNode = newNode.left;
                    else if (newNode.left == null && newNode.right != null)
                        newNode = newNode.right;
                    else if (newNode.left != null && newNode.right != null)
                    {
                        newNode = newNode.left;
                        newNode.left = newNode.right;
                    }
                }

            }
            else if(root.val > R && root.left !=  null)
            {
                newNode = new TreeNode(root.left.val);
                newNode.left  = Solution(root.left.left, L, R);
                newNode.right = Solution(root.left.right, L, R);
                
                if (newNode.val < L || newNode.val > R)
                {
                    if (newNode.left == null && newNode.right == null)
                        newNode = null;
                    else if (newNode.left != null && newNode.right == null)
                        newNode = newNode.left;
                    else if (newNode.left == null && newNode.right != null)
                        newNode = newNode.right;
                    else if (newNode.left != null && newNode.right != null)
                    {
                        newNode = newNode.left;
                        newNode.left = newNode.right;
                    }
                }
            }
        }

        return newNode;
    }
}