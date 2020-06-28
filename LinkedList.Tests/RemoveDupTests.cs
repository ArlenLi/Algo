using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace LinkedList.Tests
{
    public class RemoveDupTests
    {
        Node LinkedList1;
        Node LinkedList2;
        [SetUp]
        public void Setup()
        {
            LinkedList1 = new Node(1).AppendToTail(1).AppendToTail(2).AppendToTail(2).AppendToTail(3).AppendToTail(3).AppendToTail(4)
                .AppendToTail(5).AppendToTail(5);
            LinkedList2 = new Node(1).AppendToTail(1).AppendToTail(1);
        }

        [Test]
        public void RemoveDupWithBuffer_Test()
        {
            RemoveDup.RemoveDupWithBuffer(LinkedList1);
            RemoveDup.RemoveDupWithBuffer(LinkedList2);
            var result1 = "";
            var node = LinkedList1;
            while(node != null)
            {
                result1 += node.Data;
                result1 += "-";
                node = node.Next;
            }           
            var expectedResult1 = "1-2-3-4-5-";
            result1.Should().Equals(expectedResult1);

            var result2 = "";
            node = LinkedList2;
            while (node != null)
            {
                result2 += node.Data;
                result2 += "-";
                node = node.Next;
            }
            var expectedResult2 = "1-";
            result2.Should().Be(expectedResult2);

        }

        [Test]
        public void RemoveDupWithoutBuffer_Test()
        {
            RemoveDup.RemoveDupWithoutBuffer(LinkedList1);
            RemoveDup.RemoveDupWithoutBuffer(LinkedList2);
            var result1 = "";
            var node = LinkedList1;
            while (node != null)
            {
                result1 += node.Data;
                result1 += "-";
                node = node.Next;
            }
            var expectedResult1 = "1-2-3-4-5-";
            result1.Should().Equals(expectedResult1);

            var result2 = "";
            node = LinkedList2;
            while (node != null)
            {
                result2 += node.Data;
                result2 += "-";
                node = node.Next;
            }
            var expectedResult2 = "1-";
            result2.Should().Be(expectedResult2);

        }
    }
}