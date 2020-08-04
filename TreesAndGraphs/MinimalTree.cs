using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs
{
    public class MinimalTree
    {
        public static BinaryTreeNode<int> MinimalTreeAlgo (int[] array)
        {
            return MinimalTreeAlgo(array, 0, array.Length - 1);
        }

        private static BinaryTreeNode<int> MinimalTreeAlgo(int[] array, int startingIndex, int endingIndex)
        {
            if (startingIndex > endingIndex)
                return null;
            var midIndex = (startingIndex + endingIndex) / 2;
            var node = new BinaryTreeNode<int>(array[midIndex]);
            node.Left = MinimalTreeAlgo(array, startingIndex, midIndex - 1);
            node.Right = MinimalTreeAlgo(array, midIndex + 1, endingIndex);
            return node;
        }
    }
}
