using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class FirstCommonAncestorTests
    {
        private BinaryTreeNode<int> root;
        private BinaryTreeNode<int> rootLeft;
        private BinaryTreeNode<int> rootRight;
        private BinaryTreeNode<int> rootLeftLeft;
        private BinaryTreeNode<int> rootLeftRight;
        private BinaryTreeNode<int> rootLeftLeftLeft;
        private BinaryTreeNode<int> rootLeftLeftRight;
        private BinaryTreeNode<int> rootRightLeft;
        private BinaryTreeNode<int> rootRightLeftLeft;
        private BinaryTreeNode<int> rootRightLeftRight;

        [SetUp]
        public void Setup()
        {
            root = new BinaryTreeNode<int>(0);
            rootLeft = new BinaryTreeNode<int>(1);
            rootRight = new BinaryTreeNode<int>(2);
            root.Left = rootLeft;
            root.Right = rootRight;
            rootLeftLeft = new BinaryTreeNode<int>(3);
            rootLeftRight = new BinaryTreeNode<int>(4);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            rootLeftLeftLeft = new BinaryTreeNode<int>(5);
            rootLeftLeftRight = new BinaryTreeNode<int>(6);
            rootLeftLeft.Left = rootLeftLeftLeft;
            rootLeftLeft.Right = rootLeftLeftRight;
            rootRightLeft = new BinaryTreeNode<int>(7);
            rootRight.Left = rootRightLeft;
            rootRightLeftLeft = new BinaryTreeNode<int>(8);
            rootRightLeftRight = new BinaryTreeNode<int>(9);
            rootRightLeft.Left = rootRightLeftLeft;
            rootRightLeft.Right = rootRightLeftRight;
        }

        [Test]
        public void FirstCommonAncestorAlgo_TwoNodesHaveSameParent()
        {
            // Arrange & Act
            var actual = FirstCommonAncestor<int>.FirstCommonAncestorAlgo(root, rootLeftLeftLeft, rootLeftLeftRight);

            // Assert
            actual.Should().Be(rootLeftLeft);
        }

        [Test]
        public void FirstCommonAncestorAlgo_TwoNodesHaveDiffParent()
        {
            // Arrange & Act
            var actual = FirstCommonAncestor<int>.FirstCommonAncestorAlgo(root, rootLeftLeftLeft, rootLeftRight);

            // Assert
            actual.Should().Be(rootLeft);
        }

        [Test]
        public void FirstCommonAncestorAlgo_TwoNodesHaveDiffParent_CommonAncestorIsRoot()
        {
            // Arrange & Act
            var actual = FirstCommonAncestor<int>.FirstCommonAncestorAlgo(root, rootLeftLeftLeft, rootRightLeftRight);

            // Assert
            actual.Should().Be(root);
        }

        [Test]
        public void FirstCommonAncestorAlgo_OnlyOneNodeInTheTree()
        {
            // Arrange & Act
            var actual = FirstCommonAncestor<int>.FirstCommonAncestorAlgo(root, rootLeftLeftLeft, new BinaryTreeNode<int>(10));

            // Assert
            actual.Should().Be(null);
        }

        [Test]
        public void FirstCommonAncestorAlgo_NeitherNodesInTheTree()
        {
            // Arrange & Act
            var actual = FirstCommonAncestor<int>.FirstCommonAncestorAlgo(root, new BinaryTreeNode<int>(10), new BinaryTreeNode<int>(11));

            // Assert
            actual.Should().Be(null);
        }

    }
}
