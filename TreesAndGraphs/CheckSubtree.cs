using System.Text;

namespace TreesAndGraphs
{
    /*Check Subtree: Tl and T2 are two very large binary trees, with Tl much bigger than T2. Create an
     *algorithm to determine if T2 is a subtree of Tl.
     *A tree T2 is a subtree ofTi if there exists a node n in Ti such that the subtree of n is identical to T2.
     *That is, if you cut off the tree at node n, the two trees would be identical.
     */
    public class CheckSubtree
    {
        public static bool CheckSubtreeAlgo(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
        {
            if (t1 == null || t2 == null)
                return false;
            var t1StringBuilder = new StringBuilder();
            var t2StringBuilder = new StringBuilder();
            PreorderTraverse(t1, t1StringBuilder);
            PreorderTraverse(t2, t2StringBuilder);

            return t1StringBuilder.ToString().Contains(t2StringBuilder.ToString());
        }

        private static void PreorderTraverse(BinaryTreeNode<int> node, StringBuilder stringBuilder)
        {
            if (node == null)
                stringBuilder.Append("X");
            else
            {
                stringBuilder.Append(node.Data + " ");
                PreorderTraverse(node.Left, stringBuilder);
                PreorderTraverse(node.Right, stringBuilder);                
            }
        }
    }
}
