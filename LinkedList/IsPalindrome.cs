using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class IsPalindrome
    {
        public static bool IsPalindromeReverseAlgo(Node head)
        {
            if (head == null)
                return false;
            Node reverseLinkedListHead = null;
            var pointer = head;
            while(pointer != null)
            {
                var newReverseLinkedListHead = new Node(pointer.Data);
                newReverseLinkedListHead.Next = reverseLinkedListHead;
                reverseLinkedListHead = newReverseLinkedListHead;
                pointer = pointer.Next;
            }
            pointer = head;
            var reversePointer = reverseLinkedListHead;
            while(pointer != null &&
                reversePointer != null)
            {
                if (pointer.Data != reversePointer.Data)
                    return false;
                else
                {
                    pointer = pointer.Next;
                    reversePointer = reversePointer.Next;
                }
            }
            return true;
        }

        public static bool IsPalindromRecursiveAlgo(Node head)
        {
            return Compare(head, head.Length).IsSame;
        }

        private static CompareResult Compare(Node node, int leftNodesNum)
        {
            if(leftNodesNum == 0)
            {
                return new CompareResult(node, true);
            }
            if(leftNodesNum == 1)
            {
                return new CompareResult(node.Next, true);
            }

            var compareResult = Compare(node.Next, leftNodesNum - 2);

            if(!compareResult.IsSame)
            {
                return compareResult;
            }
            else
            {
                var isSame = compareResult.NextNode.Data == node.Data;
                return new CompareResult(compareResult.NextNode.Next, isSame);
            }
        }

        private class CompareResult
        {
            public Node NextNode;
            public bool IsSame;

            public CompareResult(Node nextNode, bool isSame)
            {
                NextNode = nextNode;
                IsSame = isSame;
            }
        }
            

    }
}
