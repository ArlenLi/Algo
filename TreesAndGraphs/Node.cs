using System.Collections.Generic;

namespace TreesAndGraphs
{
    public class Node<T>
    {
        public T Data;
        public List<Node<T>> children;

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
