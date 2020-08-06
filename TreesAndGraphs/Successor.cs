using System.Net;

namespace TreesAndGraphs
{
    /*
     * Successor: Write an algorithm to find the "next" node (i .e., in-order successor) of a given node in a
     * binary search tree. You may assume that each node has a link to its parent.
     */
    public class Successor<T>
    {
        public static BinaryTreeNode<T> FindSuccessorInOrderTraveral(BinaryTreeNode<T> node)
        {
            if(node.Right != null)
            {
                node = node.Right;
                while(node.Left != null)
                {
                    node = node.Left;
                }
            }

            else if(node == node.Parent.Left)
            {
                node = node.Parent;
            }

            else if (node == node.Parent.Right)
            {
                node = node.Parent;
                while (node != null)
                {
                    if (node.Parent != null && node == node.Parent.Left)
                    {
                        node = node.Parent;
                        break;
                    }
                    node = node.Parent;
                }
            }
            return node;
        }
    }
}
