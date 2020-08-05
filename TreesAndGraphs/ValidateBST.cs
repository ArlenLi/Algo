namespace TreesAndGraphs
{
    public class ValidateBST
    {
        /*
         * Validate BST: Implement a function to check if a binary tree is a binary search tree.
         */
        public static bool ValidateBSTAlgo(BinaryTreeNode<int> root)
        {
            return ValidateBSTAlgo(root, null, null);
        }

        private static bool ValidateBSTAlgo(BinaryTreeNode<int> node, int? min, int? max)
        {
            if (node == null)
                return true;
            if ((min != null && node.Data.CompareTo(min) < 0) ||
                (max != null && node.Data.CompareTo(max) >= 0))
                return false;
            var validateLeft = ValidateBSTAlgo(node.Left, min, node.Data);
            var validateRight = ValidateBSTAlgo(node.Right, node.Data, max);
            return validateLeft && validateRight;
        }
    }
}
