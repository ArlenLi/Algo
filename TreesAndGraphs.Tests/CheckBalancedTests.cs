using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class CheckBalancedTests
    {
        [Test]
        public void IsBalanced_WhenTreeIsBalanced_AndHeightDiffIsZero_ReturnsTrue()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(4);
            var rootRight = new BinaryTreeNode<int>(4);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(2);
            var rootLeftRight = new BinaryTreeNode<int>(8);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(20);
            rootRight.Right = rootRightRight;

            // Act
            var actual = CheckBalanced<int>.IsBalanced(root);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void IsBalanced_WhenTreeIsBalanced_AndHeighDiffIsOne_ReturnsTrue()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(4);
            var rootRight = new BinaryTreeNode<int>(4);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(2);
            var rootLeftRight = new BinaryTreeNode<int>(8);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;

            // Act
            var actual = CheckBalanced<int>.IsBalanced(root);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void IsBalanced_WhenTreeIsNotBalanced_ReturnsFalse()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(4);
            root.Left = rootLeft;
            var rootLeftLeft = new BinaryTreeNode<int>(2);
            rootLeft.Left = rootLeftLeft;
            var rootLeftLeftleft = new BinaryTreeNode<int>(8);
            rootLeftLeft.Left = rootLeftLeftleft;
            var rootRight = new BinaryTreeNode<int>(3);
            rootRight.Right = new BinaryTreeNode<int>(33);

            // Act
            var actual = CheckBalanced<int>.IsBalanced(root);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
