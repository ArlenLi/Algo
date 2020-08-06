using FluentAssertions;
using NUnit.Framework;

namespace TreesAndGraphs.Tests
{
    public class SuccessorTests
    {   
        [Test]
        public void FindSuccessorInOrderTraveral_NodeHasRightChild_ReturnLeftmostNodeRightSubTree()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(5, root);
            var rootRight = new BinaryTreeNode<int>(30, root);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(3, rootLeft);
            var rootLeftRight = new BinaryTreeNode<int>(8, rootLeft);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(40, rootRight);
            rootRight.Right = rootRightRight;
            var rootRightRightLeft = new BinaryTreeNode<int>(35, rootRightRight);
            var rootRightRightRight = new BinaryTreeNode<int>(50, rootRightRight);
            rootRightRight.Left = rootRightRightLeft;
            rootRightRight.Right = rootRightRightRight;

            // Act
            var actual = Successor<int>.FindSuccessorInOrderTraveral(rootLeft);

            // Assert
            actual.Should().Be(rootLeftRight);
        }

        [Test]
        public void FindSuccessorInOrderTraveral_NodeHasNoRightChild_NodeIsLeftChildOfParent_ReturnParent()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(5, root);
            var rootRight = new BinaryTreeNode<int>(30, root);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(3, rootLeft);
            var rootLeftRight = new BinaryTreeNode<int>(8, rootLeft);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(40, rootRight);
            rootRight.Right = rootRightRight;
            var rootRightRightLeft = new BinaryTreeNode<int>(35, rootRightRight);
            var rootRightRightRight = new BinaryTreeNode<int>(50, rootRightRight);
            rootRightRight.Left = rootRightRightLeft;
            rootRightRight.Right = rootRightRightRight;

            // Act
            var actual = Successor<int>.FindSuccessorInOrderTraveral(rootLeftLeft);

            // Assert
            actual.Should().Be(rootLeft);
        }

        [Test]
        public void FindSuccessorInOrderTraveral_NodeHasNoRightChild_NodeIsRightChildOfParent_NodeIsNotLastNodeOfInOrderTraversal_ReturnParentOfFirstNodeWhichIsLeftChild()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(5, root);
            var rootRight = new BinaryTreeNode<int>(30, root);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(3, rootLeft);
            var rootLeftRight = new BinaryTreeNode<int>(8, rootLeft);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(40, rootRight);
            rootRight.Right = rootRightRight;
            var rootRightRightLeft = new BinaryTreeNode<int>(35, rootRightRight);
            var rootRightRightRight = new BinaryTreeNode<int>(50, rootRightRight);
            rootRightRight.Left = rootRightRightLeft;
            rootRightRight.Right = rootRightRightRight;

            // Act
            var actual = Successor<int>.FindSuccessorInOrderTraveral(rootLeftRight);

            // Assert
            actual.Should().Be(root);
        }

        [Test]
        public void FindSuccessorInOrderTraveral_NodeHasNoRightChild_NodeIsRightChildOfParent_NodeIsLastNodeOfInOrderTraversal_ReturnNull()
        {
            // Arrange
            var root = new BinaryTreeNode<int>(10);
            var rootLeft = new BinaryTreeNode<int>(5, root);
            var rootRight = new BinaryTreeNode<int>(30, root);
            root.Left = rootLeft;
            root.Right = rootRight;
            var rootLeftLeft = new BinaryTreeNode<int>(3, rootLeft);
            var rootLeftRight = new BinaryTreeNode<int>(8, rootLeft);
            rootLeft.Left = rootLeftLeft;
            rootLeft.Right = rootLeftRight;
            var rootRightRight = new BinaryTreeNode<int>(40, rootRight);
            rootRight.Right = rootRightRight;
            var rootRightRightLeft = new BinaryTreeNode<int>(35, rootRightRight);
            var rootRightRightRight = new BinaryTreeNode<int>(50, rootRightRight);
            rootRightRight.Left = rootRightRightLeft;
            rootRightRight.Right = rootRightRightRight;

            // Act
            var actual = Successor<int>.FindSuccessorInOrderTraveral(rootRightRightRight);

            // Assert
            actual.Should().Be(null);
        }
    }
}
