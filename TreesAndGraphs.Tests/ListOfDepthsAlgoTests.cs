using FluentAssertions;
using NUnit.Framework;

namespace TreesAndGraphs.Tests
{
    public class ListOfDepthsAlgoTests
    {
        [Test]
        public void ListOfDepthsAlgo_WhenRootIsNull_ReturnsEmptyLists()
        {
            // Arrange & Act
            var results = ListOfDepths<int>.ListOfDepthsAlgo(null);

            // Assert
            results.Count.Should().Be(0);
        }

        [Test]
        public void ListOfDepthsAlgo_WhenRootIsNotNull_ReturnsCorrectLists()
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
            var results = ListOfDepths<int>.ListOfDepthsAlgo(root);

            // Assert
            results.Count.Should().Be(3);
            results[0].Count.Should().Be(1);
            results[1].Count.Should().Be(2);
            results[2].Count.Should().Be(3);
        }
    }
}
