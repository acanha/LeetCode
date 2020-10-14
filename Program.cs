using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem669();
            /* 
                        var node = new TreeNode(3)
                        {
                            left  = new TreeNode(0)
                            {
                                right = new TreeNode(2)
                                {
                                    left = new TreeNode(1)

                                }
                            },
                            right = new TreeNode(4)
                        };
            */
            //[3,1,4,null,2]
            /*
                   3
                 /   \
                1     4
                 \   
                  2
                 /
                1
             */
            var node = new TreeNode(3)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(2)
                },
                right = new TreeNode(4)

            };

            var result = problem.Solution(node, 3, 4);
        }
    }
}
