using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests
{
    public class DeleteMiddleNodeTests
    {
        [Test]
        public void DeleteMiddleNodetest()
        {
            var nodeToBeDeleted = new Node(15);
            var head = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(nodeToBeDeleted).AppendToTail(4).AppendToTail(5).AppendToTail(6)
                .AppendToTail(7).AppendToTail(8);

            DeleteMiddleNode.DeleteMiddleNodeAlgo(nodeToBeDeleted);

            var node = head;
            var result = "";
            var expected = "1-2-3-4-5-6-7-8";
            while(node != null)
            {
                result += node.Data;
                result += "-";
                node = node.Next;
            }

            result.Substring(0, result.Length - 1).Should().Be(expected);
        }
    }
}
