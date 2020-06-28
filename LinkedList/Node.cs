using System;

namespace LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public int Length => CalculateLength();

        public Node()
        {

        }
        public Node(int data)
        {
            Data = data;
        }

        public Node AppendToTail(int data)
        {
            var endNode = new Node(data);
            var node = this;
            while(node.Next != null)
            {
                node = node.Next;
            }
            node.Next = endNode;
            return this;
        }

        public Node AppendToTail(Node toBeAppendedNode)
        {
            var endNode = toBeAppendedNode;
            var node = this;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = endNode;
            return this;
        }

        private int CalculateLength()
        {
            var counter = 0;
            var pointer = this;
            while(pointer != null)
            {
                counter++;
                pointer = pointer.Next;
            }
            return counter;
        }
    }
}
