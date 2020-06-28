using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        public DoublyLinkedNode Head { get; set; }
        public DoublyLinkedNode Tail { get; set; }

        public void AppendToTail(int data) {
            if (Head == null)
            {
                Tail = Head = new DoublyLinkedNode(data);
            }

            var node = new DoublyLinkedNode(data);

            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        public void AppendBeforeHand(int data)
        {
            if(Head == null)
            {
                Tail = Head = new DoublyLinkedNode(data);
            }

            var node = new DoublyLinkedNode(data);

            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        public bool Delete(int data)
        {
            if (Head == null)
                return false;
            if(Head == Tail && Head.Data == data)
            {
                Head = Tail = null;
                return true;
            }

            var node = Head;
            while (node != null)
            {         
                if(node.Data == data)
                {
                    if (node == Head)
                    {
                        node.Next.Previous = null;
                        Head = node.Next;
                    }
                    else if (node == Tail)
                    {
                        node.Previous.Next = null;
                        Tail = node.Previous;
                    }
                    else
                    {
                        node.Previous.Next = node.Next;
                        node.Next.Previous = node.Previous;
                    }
                    return true;
                }
                node = node.Next;
            }
            return false;
        }
    }

    public class DoublyLinkedNode {
        public int Data { get; set; }
        public DoublyLinkedNode Previous { get; set; }
        public DoublyLinkedNode Next { get; set; }

        public DoublyLinkedNode(int data)
        {
            Data = data;
        }
    }
}
