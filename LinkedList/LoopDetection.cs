using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    /*
     * Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the
       beginning of the loop.
       DEFINITION
       Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so
       as to make a loop in the linked list.
       EXAMPLE
       Input: A -) B -) C -) 0 -) E - ) C[thesameCasearlierl
       Output: C
     */
    public class LoopDetection
    {
        public static Node LoopDetectionAlgo(Node head)
        {
            var fastPointer = head;
            var slowPointer = head;
            while(fastPointer != null && fastPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (Object.ReferenceEquals(slowPointer, fastPointer))
                    break;
            }

            if (fastPointer == null || fastPointer.Next == null)
                return null;

            slowPointer = head;
            while(!Object.ReferenceEquals(slowPointer, fastPointer)) {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next;
            }
            return slowPointer;
        }
    }
}
