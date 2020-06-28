using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests
{
    public class PartitionTests
    {
        [Test]
        public void PartitionTest()
        {
            var head = new Node(3).AppendToTail(5).AppendToTail(8).AppendToTail(5).AppendToTail(10).AppendToTail(2).AppendToTail(1);

            var result = Partition.PartitionAlgo(head, 5);
            
            result.Should().BeOfType(typeof(Node));
            var node = result;
            var elementLessThanPartitionCount = 3;

            while(result != null)
            {
                if(elementLessThanPartitionCount > 0)
                {
                    result.Data.Should().BeLessThan(5);
                    elementLessThanPartitionCount--;
                }
                else
                {
                    result.Data.Should().BeGreaterOrEqualTo(5);
                }
                result = result.Next;
            }

        }
    }
}
