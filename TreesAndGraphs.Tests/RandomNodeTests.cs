using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class RandomNodeTests
    {
        private RandomNode root;

        [SetUp]
        public void SetUp()
        {
            root = new RandomNode(50);
            root.Insert(40);
            root.Insert(30);
            root.Insert(100);
            root.Insert(70);
            root.Insert(80);

        }
        [Test]
        public void Insert_WhenInsertANode_NodeShouldBeInsertedCorrectly()
        {
           
            // Assert
            root.Size.Should().Be(6);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(2);
            root.Left.Left.Data.Should().Be(30);
            root.Left.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(3);
            root.Right.Left.Data.Should().Be(70);
            root.Right.Left.Size.Should().Be(2);
            root.Right.Left.Right.Data.Should().Be(80);
            root.Right.Left.Right.Size.Should().Be(1);
        }

        [Test]
        public void Find_WhenNodeNotExists_ReturnsNull()
        {
            // Act
            var actual = root.Find(99);

            // Assrt
            actual.Should().BeNull();
        }

        [Test]
        public void Find_WhenNodeExists_ReturnsCorrectNode()
        {
            // Act
            var actual = root.Find(80);

            // Assrt
            actual.Data.Should().Be(80);
        }

        [Test]
        public void Delete_WhenNodeNotExists_ReturnsFalse()
        {
            // Act
            var actual = RandomNode.Delete(root, 99);

            // Assert
            actual.Deleted.Should().BeFalse();
            root.Size.Should().Be(6);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(2);
            root.Left.Left.Data.Should().Be(30);
            root.Left.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(3);
            root.Right.Left.Data.Should().Be(70);
            root.Right.Left.Size.Should().Be(2);
            root.Right.Left.Right.Data.Should().Be(80);
            root.Right.Left.Right.Size.Should().Be(1);
        }

        [Test]
        public void Delete_WhenNodeIsLeaf_DeleteNodeCorrectly()
        {
            // Act
            var actual = RandomNode.Delete(root, 30);

            // Assert
            actual.Deleted.Should().BeTrue();
            root.Size.Should().Be(5);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(1);
            root.Left.Left.Should().BeNull();            
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(3);
            root.Right.Left.Data.Should().Be(70);
            root.Right.Left.Size.Should().Be(2);
            root.Right.Left.Right.Data.Should().Be(80);
            root.Right.Left.Right.Size.Should().Be(1);
        }

        [Test]
        public void Delete_WhenNodeHasLeftAndRightChild_DeleteNodeCorrectly()
        {
            // Arrange
            root.Insert(110);
            // Act
            var actual = RandomNode.Delete(root, 100);

            // Assert
            actual.Deleted.Should().BeTrue();
            root.Size.Should().Be(6);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(2);
            root.Left.Left.Data.Should().Be(30);
            root.Left.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(110);
            root.Right.Size.Should().Be(3);
            root.Right.Left.Data.Should().Be(70);
            root.Right.Left.Size.Should().Be(2);
            root.Right.Left.Right.Data.Should().Be(80);
            root.Right.Left.Right.Size.Should().Be(1);
        }

        [Test]
        public void Delete_WhenNodeHasLeftChild_DeleteNodeCorrectly()
        {
            // Act
            var actual = RandomNode.Delete(root, 40);

            // Assert
            actual.Deleted.Should().BeTrue();
            root.Size.Should().Be(5);
            root.Left.Data.Should().Be(30);
            root.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(3);
            root.Right.Left.Data.Should().Be(70);
            root.Right.Left.Size.Should().Be(2);
            root.Right.Left.Right.Data.Should().Be(80);
            root.Right.Left.Right.Size.Should().Be(1);
        }

        [Test]
        public void Delete_WhenNodeHasRightChild_DeleteNodeCorrectly()
        {
            // Act
            var actual = RandomNode.Delete(root, 70);

            // Assert
            actual.Deleted.Should().BeTrue();
            root.Size.Should().Be(5);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(2);
            root.Left.Left.Data.Should().Be(30);
            root.Left.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(2);
            root.Right.Left.Data.Should().Be(80);
            root.Right.Left.Size.Should().Be(1);
        }

        [Test]
        public void Delete_WhenNodeIsRoot_DeleteNodeCorrectly()
        {
            // Act
            var actual = RandomNode.Delete(root, 50);

            // Assert
            actual.Deleted.Should().BeTrue();
            root.Data.Should().Be(70);
            root.Size.Should().Be(5);
            root.Left.Data.Should().Be(40);
            root.Left.Size.Should().Be(2);
            root.Left.Left.Data.Should().Be(30);
            root.Left.Left.Size.Should().Be(1);
            root.Right.Data.Should().Be(100);
            root.Right.Size.Should().Be(2);
            root.Right.Left.Data.Should().Be(80);
            root.Right.Left.Size.Should().Be(1);
        }

        [Test]
        public void GetRandomNode_ReturnsRandomNode()
        {
            // Act
            for(int i = 0; i < 10; i++) { 
                var actual = RandomNode.GetRandomNode(root, null);
            }
        }
    }
}
