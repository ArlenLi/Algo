using System.Collections.Generic;

namespace TreesAndGraphs
{
    public class ListOfDepths
    {
        public static List<List<BinaryTreeNode<int>>> ListOfDepthsAlgo(BinaryTreeNode<int> root)
        {
            var results = new List<List<BinaryTreeNode<int>>>();
            if (root == null)
                return results;
            var currectDepthList = new List<BinaryTreeNode<int>>();
            var nextDepthList = new List<BinaryTreeNode<int>>();
            currectDepthList.Add(root);
            while(currectDepthList.Count != 0)
            {
                results.Add(currectDepthList);
                nextDepthList = new List<BinaryTreeNode<int>>();
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
