using System.Collections;

namespace TreesAndGraphs
{
    /*Paths with Sum: You are given a binary tree in which each node contains an integer value (which
     *might be positive or negative). Design an algorithm to count the number of paths that sum to a
     *given value. The path does not need to start or end at the root or a leaf, but it must go downwards
     *(traveling only from parent nodes to child nodes).
     */
    public class PathWithSum
    {
        public static int PathWithSumAlgo(BinaryTreeNode<int> node, int givenNum)
        {
            return PathWithSumAlgo(node, givenNum, 0, new Hashtable());
        }

        private static int PathWithSumAlgo(BinaryTreeNode<int> node, int givenNum, int currentSum, Hashtable hashtable)
        {
            if (node == null)
                return 0;
            var counter = 0;
            currentSum += node.Data;
            var runningSum = currentSum - givenNum;
            if(hashtable.ContainsKey(runningSum))
            {
                counter += (int)hashtable[runningSum];
            }

            if (currentSum == givenNum)
                counter++;

            if (hashtable.ContainsKey(currentSum))
                hashtable[currentSum] = (int)hashtable[currentSum] + 1;
            else
                hashtable[currentSum] = 1;

            var leftCounter = PathWithSumAlgo(node.Left, givenNum, currentSum, hashtable);
            var rightCounter = PathWithSumAlgo(node.Right, givenNum, currentSum, hashtable);

            if ((int)hashtable[currentSum] == 1)
                hashtable.Remove(currentSum);
            else
                hashtable[currentSum] = (int)hashtable[currentSum] - 1;

            return counter + leftCounter + rightCounter;
        }
    }
}
