using FluentAssertions;
using FluentAssertions.Specialized;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class PathWithSumTests
    {
        [Test]
        public void PathWithSumTests_GivenATreeNode_GivenNumIs0_ReturnsCorrectResult()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(3);
            var rootLeft = new BinaryTreeNode<int>(7);
            var rootRight = new BinaryTreeNode<int>(10);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(-10);
            var rootLeftRight = new BinaryTreeNode<int>(6);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootLeftLeftLeft = new BinaryTreeNode<int>(10);
            rootLeftLeft.Left = rootLeftLeftLeft;
            var rootRightLeft = new BinaryTreeNode<int>(7);
            var rootRightRight = new BinaryTreeNode<int>(-13);
            rootRight.Left = rootRightLeft;
            rootRight.Right = rootRightRight;

            // Act
            var actual = PathWithSum.PathWithSumAlgo(root, 0);

            // Assert
            actual.Should().Be(3);
        }

        [Test]
        public void PathWithSumTests_GivenATreeNode_GiveNumIs10_ReturnsCorrectResult()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(3);
            var rootLeft = new BinaryTreeNode<int>(7);
            var rootRight = new BinaryTreeNode<int>(10);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(-10);
            var rootLeftRight = new BinaryTreeNode<int>(6);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootLeftLeftLeft = new BinaryTreeNode<int>(10);
            rootLeftLeft.Left = rootLeftLeftLeft;
            var rootRightLeft = new BinaryTreeNode<int>(7);
            var rootRightRight = new BinaryTreeNode<int>(-13);
            rootRight.Left = rootRightLeft;
            rootRight.Right = rootRightRight;

            // Act
            var actual = PathWithSum.PathWithSumAlgo(root, 10);

            // Assert
            actual.Should().Be(4);
        }
    }
}
