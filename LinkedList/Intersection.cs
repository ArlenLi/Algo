using System;

namespace LinkedList
{
    /*2.7
     * Intersection: Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting
       node. Note that the intersection is defined based on reference, not value. That is, if the kth
       node of the first linked list is the exact same node (by reference) as the jth node of the second
       linked list, then they are intersecting.
       Hints: #20, #45, #55, #65, #76, #93, #111, #120, #129
     */
    public class Intersection
    {
        public static bool IsTwoLinkedListIntersected(Node head1, Node head2)
        {
            if (head1 == null || head2 == null)
                return false;
            Node lastNodeOfLinkedList1, lastNodeOfLinkedList2;
            var pointer1 = head1;
            while (pointer1.Next != null)
            {
                pointer1 = pointer1.Next;
            }
            lastNodeOfLinkedList1 = pointer1;
            var pointer2 = head2;
            while (pointer2.Next != null)
            {
                pointer2 = pointer2.Next;
            }
            lastNodeOfLinkedList2 = pointer2;
            return Object.ReferenceEquals(lastNodeOfLinkedList1, lastNodeOfLinkedList2);
        }

        public static Node FindIntersectingNode(Node head1, Node head2)
        {
            if (!IsTwoLinkedListIntersected(head1, head2))
                return null;
            Node longerLinkedListHead, shorterLinkedListHead;
            var lengthDifference = 0;
            if (head1.Length > head2.Length)
            {
                longerLinkedListHead = head1;
                shorterLinkedListHead = head2;
                lengthDifference = head1.Length - head2.Length;
            }
            else
            {
                longerLinkedListHead = head2;
                shorterLinkedListHead = head1;
                lengthDifference = head2.Length - head1.Length;
            }

            var longerLinkedListPointer = longerLinkedListHead;
            var shorterLinkedListPointer = shorterLinkedListHead;

            for(int i = 0; i < lengthDifference; i++)
            {
                longerLinkedListPointer = longerLinkedListPointer.Next;
            }

            while(longerLinkedListPointer != null && shorterLinkedListPointer != null)
            {
                if (Object.ReferenceEquals(longerLinkedListPointer, shorterLinkedListPointer))
                    return longerLinkedListPointer;
                else
                {
                    longerLinkedListPointer = longerLinkedListPointer.Next;
                    shorterLinkedListPointer = shorterLinkedListPointer.Next;
                }
            }
            return null;
        }
    }
}
