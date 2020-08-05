using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class ValidateBSTTests
    {
        [Test]
        public void ValidateBSTAlgo_WhenTreeIsBST_ReturnsTrue()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(40);
            var rootLeft = new BinaryTreeNode<int>(25);
            var rootRight = new BinaryTreeNode<int>(40);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(24);
            var rootLeftRight = new BinaryTreeNode<int>(39);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(100);
            rootRight.Right = rootRightRight;
            var rootRightRightLeft = new BinaryTreeNode<int>(60);
            var rootRightRightRight = new BinaryTreeNode<int>(150);
            rootRightRight.Left = rootRightRightLeft;
            rootRightRight.Right = rootRightRightRight;

            // Act
            var actual = ValidateBST.ValidateBSTAlgo(root);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void ValidateBSTAlgo_WhenTreeIsBST_ReturnsTrue_2()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(40);
            var rootLeft = new BinaryTreeNode<int>(25);
            var rootRight = new BinaryTreeNode<int>(40);
            root.Left = rootLeft;
            root.Right = rootRight; 
            var rootRightRight = new BinaryTreeNode<int>(40);
            rootRight.Right = rootRightRight;
          
            // Act
            var actual = ValidateBST.ValidateBSTAlgo(root);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void ValidateBSTAlgo_WhenTreeIsNotBST_ReturnsFalse()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(40);
            var rootLeft = new BinaryTreeNode<int>(40);
            var rootRight = new BinaryTreeNode<int>(42);
            root.Left = rootLeft;
            root.Right = rootRight;

            // Act
            var actual = ValidateBST.ValidateBSTAlgo(root);

            // Assert
            actual.Should().BeFalse();
        }

        [Test]
        public void ValidateBSTAlgo_WhenTreeIsNotBST_ReturnsFalse_2()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(40);
            var rootLeft = new BinaryTreeNode<int>(39);
            var rootRight = new BinaryTreeNode<int>(42);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftRight = new BinaryTreeNode<int>(40);
            rootLeft.Right = rootLeftRight;

            // Act
            var actual = ValidateBST.ValidateBSTAlgo(root);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
