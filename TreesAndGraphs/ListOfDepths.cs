using System.Collections.Generic;

namespace TreesAndGraphs
{
    public class ListOfDepths<T>
    {
        /*
         * List of Depths: Given a binary tree, design an algorithm which creates a linked list of all the nodes
         * at each depth (e.g., if you have a tree with depth 0, you'll have 0 linked lists).
         */
        public static List<List<BinaryTreeNode<T>>> ListOfDepthsAlgo(BinaryTreeNode<T> root)
        {
            var results = new List<List<BinaryTreeNode<T>>>();
            if (root == null)
                return results;
            var currectDepthList = new List<BinaryTreeNode<T>>();
            var nextDepthList = new List<BinaryTreeNode<T>>();
            currectDepthList.Add(root);
            while(currectDepthList.Count != 0)
            {
                results.Add(currectDepthList);
                nextDepthList = new List<BinaryTreeNode<T>>();
                foreach(var node in currectDepthList)
                {
                    if (node.Left != null)
                        nextDepthList.Add(node.Left);
                    if (node.Right != null)
                        nextDepthList.Add(node.Right);
                }
                currectDepthList = nextDepthList;
            }
            return results;
        }
    }
}
