using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LinkedList
{
    /* 2.4
     * Write code to partition a linked list around a value x, such that all nodes less than x come
       before all nodes greater than or equal to x. lf x is contained within the list, the values of x only need
       to be after the elements less than x (see below). The partition element x can appear anywhere in the
       "right partition"; it does not need to appear between the left and right partitions.
       EXAMPLE
       Input: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition = 5)
       Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
     */
    public class Partition
    {
        public static Node PartitionAlgo(Node head, int partition)
        {
            var pointer = head;
            while(pointer.Next != null)
            {
                if(pointer != null && pointer.Next.Data < partition)
                {
                    var newHead = new Node(pointer.Next.Data);
                    newHead.Next = head;
                    head = newHead;
                    pointer.Next = pointer.Next.Next;
                }
                else
                {
                    pointer = pointer.Next;
                }
            }
            return head;
        }
    }
}
