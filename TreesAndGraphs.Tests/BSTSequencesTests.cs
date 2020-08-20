using FluentAssertions;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace TreesAndGraphs.Tests
{
    public class BSTSequencesTests
    {
        [Test]
        public void BSTSequencesAlgo_WhenRootIsNull_ReturnEmptyLists()
        {
            // Act
            var actual = BSTSequences.BSTSequencesAlog(null);

            // Assert
            actual.Count.Should().Be(0);
        }

        [Test]
        public void BSTSequencesAlgo_WhenTreeIsMini_ReturnCorrectLists()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(2);
            root.Left = new BinaryTreeNode<int>(1);
            root.Right = new BinaryTreeNode<int>(3);
            // Act
            var actual = BSTSequences.BSTSequencesAlog(root);

            // Assert
            actual.Count.Should().Be(2);
            actual[0][0].Should().Be(2);
            actual[1][0].Should().Be(2);
        }

        [Test]
        public void BSTSequencesAlgo_WhenTreeIsSmall_ReturnCorrectLists()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(2);
            root.Left = new BinaryTreeNode<int>(1);
            root.Right = new BinaryTreeNode<int>(4);
            root.Right.Left = new BinaryTreeNode<int>(3);

            // Act
            var actual = BSTSequences.BSTSequencesAlog(root);

            // Assert
            actual.Count.Should().Be(3);
            actual[0][0].Should().Be(2);
            actual[1][0].Should().Be(2);
            actual[2][0].Should().Be(2);
        }

        [Test]
        public void BSTSequencesAlgo_WhenTreeIsMedium_ReturnCorrectLists()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            root.Left = new BinaryTreeNode<int>(5);
            root.Left.Left = new BinaryTreeNode<int>(1);
            root.Right = new BinaryTreeNode<int>(15);
            root.Right.Left = new BinaryTreeNode<int>(12);
            root.Right.Right = new BinaryTreeNode<int>(19);


            // Act
            var actual = BSTSequences.BSTSequencesAlog(root);

            // Assert
            foreach (var eachList in actual)
            {
                var output = "";
                foreach (var num in eachList)
                {
                    output += num;
                    output += " ";
                }
                Debug.WriteLine(output);
            }
            actual.Count.Should().Be(20);
        }
    }
}
