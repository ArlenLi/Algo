namespace TreesAndGraphs
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode<T> Parent { get; set; }

        public BinaryTreeNode(T data)
        {
            Data = data;
        }

        public BinaryTreeNode(T data, BinaryTreeNode<T> parent)
        {
            Data = data;
            Parent = parent;
        }
    }
}
