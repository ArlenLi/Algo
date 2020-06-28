using System.Security.Cryptography;

namespace LinkedList
{
    public class SumLists
    {
        /*
         *  Sum Lists: You have two numbers represented by a linked list, where each node contains a single
            digit. The digits are stored in reverse order, such that the 1 's digit is at the head of the list. Write a
            function that adds the two numbers and returns the sum as a linked list.
            EXAMPLE
            Input: (7-) 1 -) 6) + (5 -) 9 -) 2) .Thatis,617 + 295.
            Output: 2 -) 1 -) 9. That is, 912.
            FOLLOW UP
            Suppose the digits are stored in forward order. Repeat the above problem.
            EXAMPLE
            Input: (6 -) 1 -) 7) + (2 -) 9 -) 5).Thatis,617 + 295.
            Output: 9 -) 1 -) 2. That is, 912.
         */
        public static Node SumListsInReverseOrder(Node head1, Node head2)
        {
            var pointer1 = head1;
            var pointer2 = head2;
            Node result = null;
            var sum = 0;
            var carrier = 0;

            while(pointer1 != null || pointer2 != null)
            {
                sum = (pointer1 != null ? pointer1.Data : 0)
                    + (pointer2 != null ? pointer2.Data : 0) + carrier;
                var value = sum % 10;
                if (result == null)
                    result = new Node(value);
                else
                    result.AppendToTail(value);
                carrier = sum / 10;

                if (pointer1 != null)
                    pointer1 = pointer1.Next;
                if (pointer2 != null)
                    pointer2 = pointer2.Next;               
            }

            if (carrier == 1)
                result.AppendToTail(1);
            return result;
        }

        public static Node SumListsInForwardOrder(Node head1, Node head2)
        {
            if(head1.Length < head2.Length)
            {
                head1 = Pad(head1, head2.Length - head1.Length);
            }
            else
            {
                head2 = Pad(head2, head1.Length - head2.Length);
            }

            var sumResult = Sum(head1, head2);
            if (sumResult.Carrier == 0)
                return sumResult.Sum;
            else
                return InsertBefore(sumResult.Sum, sumResult.Carrier);
        }

        private static Node Pad(Node head, int paddingNum)
        {
            var counter = 0;
            var newHead = head;
            while(counter < paddingNum)
            {
                newHead = InsertBefore(newHead, 0);
                counter++;
            }
            return newHead;
        }

        private static Node InsertBefore(Node head, int num)
        {
            var newHead = new Node(num);
            newHead.Next = head;
            return newHead;
        }

        private static SumResult Sum(Node pointer1, Node pointer2)
        {
            if (pointer1 == null && pointer2 == null)
                return new SumResult();

            var nextSumResult = Sum(pointer1.Next, pointer2.Next);
            var currentSumValue = pointer1.Data + pointer2.Data + nextSumResult.Carrier;
            var sum = InsertBefore(nextSumResult.Sum, currentSumValue % 10);
            return new SumResult
            {
                Sum = sum,
                Carrier = currentSumValue / 10
            };
        }

        private class SumResult
        {
            public Node Sum;
            public int Carrier;
        }


    }
}
