using FluentAssertions;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace TreesAndGraphs.Tests
{
    public class RouteBetweenNodesTests
    {
        [Test]
        public void RouteBetweenNodes_SourceSameAsTarget_ReturnsTrue()
        {
            // Arrange
            var node = new Node<int>(3);

            // Act
            var actual = RouteBetweenNodes<int>.BidirectionalSearch(node, node);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void RouteBetweenNodes_SourceNotSameAsTarget_SourceCanRouteToTarget_ReturnsTrue()
        {
            // Arrange
            var node0 = new Node<int>(0);
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            node0.children = new List<Node<int>> { node1, node4, node5 };
            node1.children = new List<Node<int>> { node4, node3 };
            node2.children = new List<Node<int>> { node1};
            node3.children = new List<Node<int>> { node2, node4 };
            node4.children = new List<Node<int>>();
            node5.children = new List<Node<int>>();


            // Act
            var actual1 = RouteBetweenNodes<int>.BidirectionalSearch(node0, node3);
            var actual2 = RouteBetweenNodes<int>.BidirectionalSearch(node0, node2);

            // Assert
            actual1.Should().BeTrue();
            actual2.Should().BeTrue();
        }

        [Test]
        public void RouteBetweenNodes_SourceNotSameAsTarget_SourceCanNotRouteToTarget_ReturnsTrue()
        {
            // Arrange
            var node0 = new Node<int>(0);
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            node0.children = new List<Node<int>> { node1, node4, node5 };
            node1.children = new List<Node<int>> { node4, node3 };
            node2.children = new List<Node<int>> { node1 };
            node3.children = new List<Node<int>> { node2, node4 };
            node4.children = new List<Node<int>>();
            node5.children = new List<Node<int>>();

            // Act
            var actual1 = RouteBetweenNodes<int>.BidirectionalSearch(node5, node3);
            var actual2 = RouteBetweenNodes<int>.BidirectionalSearch(node5, node2);

            // Assert
            actual1.Should().BeFalse();
            actual2.Should().BeFalse();
        }
    }
}