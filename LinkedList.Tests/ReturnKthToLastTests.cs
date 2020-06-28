using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests
{
    public class ReturnKthToLastTests
    {
        Node LinkedList1;
        Node LinkedList2;
        [SetUp]
        public void Setup()
        {
            LinkedList1 = new Node(1).AppendToTail(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(5).AppendToTail(6)
                .AppendToTail(7).AppendToTail(8);
            LinkedList2 = new Node(1).AppendToTail(1).AppendToTail(1);
        }

        [Test]
        public void ReturnKthToLastAlgoTest()
        {
            var result1 = ReturnKthToLast.ReturnKthToLastAlgo(LinkedList1, 0);
            result1.Data.Should().Equals(8);
            var result2 = ReturnKthToLast.ReturnKthToLastAlgo(LinkedList1, 1);
            result2.Data.Should().Equals(7);
            var result3 = ReturnKthToLast.ReturnKthToLastAlgo(LinkedList1, 2);
            result3.Data.Should().Equals(6);
            var result4 = ReturnKthToLast.ReturnKthToLastAlgo(LinkedList1, 5);
            result4.Data.Should().Equals(3);

            Action action = () => { ReturnKthToLast.ReturnKthToLastAlgo(LinkedList1, 8); };
            action.Should().Throw<ArgumentException>("kth Node to the Last doesn't exist");
        }
    }
}
