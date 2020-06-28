using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LinkedList
{
    /*2.1
     * Remove Dups: Write code to remove duplicates from an unsorted linked list.
       FOLLOW UP
       How would you solve this problem if a temporary buffer is not allowed?
     */
    public class RemoveDup
    {
        public static Node RemoveDupWithBuffer(Node header)
        {
            if (header == null)
                return header;
            var hash = new Hashtable();
            var node = header;
            hash.Add(node.Data, "");
            while (node != null && node.Next != null)
            {
                if (hash.Contains(node.Next.Data))
                {
                    node.Next = node.Next.Next;
                }
                else
                {
                    hash.Add(node.Next.Data, "");
                    node = node.Next;
                };
            }
            return header;
        }

        public static Node RemoveDupWithoutBuffer(Node header)
        {
            if (header == null)
                return header;

            Node pointer1, pointer2;
            pointer1 = header;
            while(pointer1 != null && pointer1.Next != null)
            {
                pointer2 = pointer1;
                while(pointer2 != null && pointer2.Next != null)
                {
                    if (pointer2.Next.Data == pointer1.Data)
                        pointer2.Next = pointer2.Next.Next;
                    else
                        pointer2 = pointer2.Next;
                }
                pointer1 = pointer1.Next;
            }
            return header;

        }
    }
}
