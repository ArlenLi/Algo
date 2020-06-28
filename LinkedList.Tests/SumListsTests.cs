using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests
{
    public class SumListsTests
    {
        [Test]
        public void SumListsInReverseOrderTest_TwoListsWithSameLength()
        {
            var head1 = new Node(9).AppendToTail(7).AppendToTail(8);
            var head2 = new Node(6).AppendToTail(8).AppendToTail(5);

            var result = SumLists.SumListsInReverseOrder(head1, head2);

            var resultString = "";
            while(result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("5-6-4-1");
        }

        [Test]
        public void SumListsInReverseOrderTest_TwoListsWithDifferentLength()
        {
            var head1 = new Node(7).AppendToTail(1).AppendToTail(6).AppendToTail(3).AppendToTail(1).AppendToTail(9);
            var head2 = new Node(5).AppendToTail(9).AppendToTail(2);

            var result = SumLists.SumListsInReverseOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("2-1-9-3-1-9");
        }

        [Test]
        public void SumListsInReverseOrderTest_AdditionalCarrier()
        {
            var head1 = new Node(7).AppendToTail(1).AppendToTail(7);
            var head2 = new Node(5).AppendToTail(9).AppendToTail(2);

            var result = SumLists.SumListsInReverseOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("2-1-0-1");
        }

        [Test]
        public void SumListsInReverseOrderTest_AdditionalCarrier_2()
        {
            var head1 = new Node(1);
            var head2 = new Node(9).AppendToTail(9).AppendToTail(9);

            var result = SumLists.SumListsInReverseOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("0-0-0-1");
        }

        [Test]
        public void SumListsInForwardOrderTest_TwoListsWithSameLength()
        {
            var head1 = new Node(9).AppendToTail(7).AppendToTail(8);
            var head2 = new Node(6).AppendToTail(8).AppendToTail(5);

            var result = SumLists.SumListsInForwardOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("1-6-6-3");
        }

        [Test]
        public void SumListsInForwardOrderTest_TwoListsWithDifferentLength()
        {
            var head1 = new Node(7).AppendToTail(1).AppendToTail(6).AppendToTail(3).AppendToTail(1).AppendToTail(9);
            var head2 = new Node(5).AppendToTail(9).AppendToTail(2);

            var result = SumLists.SumListsInForwardOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("7-1-6-9-1-1");
        }

        [Test]
        public void SumListsInForwardOrderTest_AdditionalCarrier()
        {
            var head1 = new Node(7).AppendToTail(1).AppendToTail(7);
            var head2 = new Node(5).AppendToTail(9).AppendToTail(2);

            var result = SumLists.SumListsInForwardOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("1-3-0-9");
        }

        [Test]
        public void SumListsInForwardOrderTest_AdditionalCarrier_2()
        {
            var head1 = new Node(1);
            var head2 = new Node(9).AppendToTail(9).AppendToTail(9);

            var result = SumLists.SumListsInForwardOrder(head1, head2);

            var resultString = "";
            while (result != null)
            {
                resultString += result.Data;
                resultString += "-";
                result = result.Next;
            }

            resultString.TrimEnd('-').Should().Be("1-0-0-0");
        }
    }
}
