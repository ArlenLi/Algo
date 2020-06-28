using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinkedList.Tests
{
    public class IntersectionTests
    {
        [Test]
        public void IsTwoLinkedListIntersectedTest_WhenTwoLinkedListsIntersecting_ReturnsTrue()
        {
            // Arrange
            var intersectingNode = new Node(7).AppendToTail(8).AppendToTail(9);
            var head1 = new Node(1).AppendToTail(2).AppendToTail(intersectingNode);
            var head2 = new Node(3).AppendToTail(5).AppendToTail(6).AppendToTail(intersectingNode);

            // Act
            var actual = Intersection.IsTwoLinkedListIntersected(head1, head2);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void IsTwoLinkedListIntersectedTest_WhenTwoLinkedListsNotIntersecting_ReturnsFalse()
        {
            // Arrange           
            var head1 = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4);
            var head2 = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4);

            // Act
            var actual = Intersection.IsTwoLinkedListIntersected(head1, head2);

            // Assert
            actual.Should().BeFalse();
        }

        [Test]
        public void FindIntersectingNodeTest_WhenTwoLinkedListsIntersecting_ReturnsIntersectingNode()
        {
            // Arrange
            var intersectingNode = new Node(7).AppendToTail(8).AppendToTail(9);
            var head1 = new Node(1).AppendToTail(2).AppendToTail(intersectingNode);
            var head2 = new Node(3).AppendToTail(5).AppendToTail(6).AppendToTail(intersectingNode);

            // Act
            var actual = Intersection.FindIntersectingNode(head1, head2);

            // Assert
            Object.ReferenceEquals(intersectingNode, actual).Should().BeTrue();
        }

        [Test]
        public void FindIntersectingNodeTest_WhenTwoLinkedListsNotIntersecting_ReturnsNull()
        {
            // Arrange           
            var head1 = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4);
            var head2 = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4);

            // Act
            var actual = Intersection.FindIntersectingNode(head1, head2);

            // Assert
            actual.Should().Be(null);
        }

    }
}
