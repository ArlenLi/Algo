namespace TreesAndGraphs
{
    /*
     * First Common Ancestor: Design an algorithm and write code to find the first common ancestor
     * of two nodes in a binary tree. Avoid storing additional nodes in a data structure. NOTE: This is not
     * necessarily a binary search tree.
     */
    public class FirstCommonAncestor<T>
    {
        public static BinaryTreeNode<T> FirstCommonAncestorAlgo(BinaryTreeNode<T> root, BinaryTreeNode<T> p, BinaryTreeNode<T> q)
        {
            var result = FirstCommonAncestorRecursiveAlgo(root, p, q);
            return result.IsCommonAncestorFound ? result.ReturnedNode : null;
        }

        private static RecursiveResult FirstCommonAncestorRecursiveAlgo(BinaryTreeNode<T> node, BinaryTreeNode<T> p, BinaryTreeNode<T> q)
        {
            if (node == null)
                return new RecursiveResult(null, false);
            var leftRecursiveResult = FirstCommonAncestorRecursiveAlgo(node.Left, p, q);
            var rightRecursiceResult = FirstCommonAncestorRecursiveAlgo(node.Right, p, q);
            if (leftRecursiveResult.IsCommonAncestorFound)
                return leftRecursiveResult;
            if (rightRecursiceResult.IsCommonAncestorFound)
                return rightRecursiceResult;
            if (leftRecursiveResult.ReturnedNode != null && rightRecursiceResult.ReturnedNode != null)
                return new RecursiveResult(node, true);
            if (node == p || node == q)
                return new RecursiveResult(node, leftRecursiveResult.ReturnedNode != null || rightRecursiceResult.ReturnedNode != null);            
            return new RecursiveResult(leftRecursiveResult.ReturnedNode != null ? leftRecursiveResult.ReturnedNode : rightRecursiceResult.ReturnedNode, false);
        }

        private class RecursiveResult
        {
            public BinaryTreeNode<T> ReturnedNode { get; set; }
            public bool IsCommonAncestorFound { get; set; }

            public RecursiveResult(BinaryTreeNode<T> returnedNode, bool isCommonAncestorFound)
            {
                ReturnedNode = returnedNode;
                IsCommonAncestorFound = isCommonAncestorFound;
            }
        }
    }
}
