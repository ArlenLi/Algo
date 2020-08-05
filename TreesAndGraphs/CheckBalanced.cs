using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace TreesAndGraphs
{
    /*
     * Check Balanced: Implement a function to check if a binary tree is balanced. For the purposes of
     * this question, a balanced tree is defined to be a tree such that the heights of the two subtrees of any
     * node never differ by more than one.
     */
    public class CheckBalanced<T>
    {
        public static bool IsBalanced(BinaryTreeNode<T> root)
        {
            return CheckBalancedAlgo(root).IsBalanced;
        }

        private static BalancedTreeCheckResult CheckBalancedAlgo(BinaryTreeNode<T> node)
        {
            if (node == null)
                return new BalancedTreeCheckResult(0, true);

            var leftNodeCheckResult = CheckBalancedAlgo(node.Left);
            var rightNodeCheckResult = CheckBalancedAlgo(node.Right);

            return new BalancedTreeCheckResult(leftNodeCheckResult.Height > rightNodeCheckResult.Height ? leftNodeCheckResult.Height + 1 : rightNodeCheckResult.Height + 1,
                leftNodeCheckResult.IsBalanced && rightNodeCheckResult.IsBalanced && Math.Abs(leftNodeCheckResult.Height - rightNodeCheckResult.Height) <= 1);

        }

        private class BalancedTreeCheckResult
        {
            public int Height { get; set; }

            public bool IsBalanced { get; set; }

            public BalancedTreeCheckResult(int height, bool isBalanced)
            {
                Height = height;
                IsBalanced = isBalanced;
            }
        }
    }

   
}
