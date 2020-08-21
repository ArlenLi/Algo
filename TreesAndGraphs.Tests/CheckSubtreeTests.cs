using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class CheckSubtreeTests
    {
        [Test]
        public void CheckSubtreeAlgo_WhenT2IsSubtreeOfT1_ReturnsTrue()
        {
            // Arrange
            var t1 = new BinaryTreeNode<int>(3);
            t1.Left = new BinaryTreeNode<int>(5);
            t1.Right = new BinaryTreeNode<int>(7);
            t1.Left.Left = new BinaryTreeNode<int>(8);
            t1.Left.Right = new BinaryTreeNode<int>(9);
            t1.Right.Left = new BinaryTreeNode<int>(10);
            t1.Right.Left.Left = new BinaryTreeNode<int>(11);

            var t2 = new BinaryTreeNode<int>(7);
            t2.Left = new BinaryTreeNode<int>(10);
            t2.Left.Left = new BinaryTreeNode<int>(11);

            // Act
            var actual = CheckSubtree.CheckSubtreeAlgo(t1, t2);

            // Assert
            actual.Should().BeTrue();
        }
    }
}
