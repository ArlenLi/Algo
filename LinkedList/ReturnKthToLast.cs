using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LinkedList
{
    /* 
     * 2.2
     * Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
     */
    public class ReturnKthToLast
    {
        public static Node ReturnKthToLastAlgo(Node head, int kthToLast)
        {
            Node pointer1 = head;
            Node pointer2 = null;
            var counter = 0;
            
            while(pointer1.Next != null)
            {
                if(counter >= kthToLast)
                {
                    pointer2 = pointer1;
                }
                counter++;
                pointer1 = pointer1.Next;
            }

            if (pointer2 == null)
                throw new ArgumentException("kth Node to the Last doesn't exist");
            return pointer2;
        }
    }
}
