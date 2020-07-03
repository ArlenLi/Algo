using FluentAssertions;
using NUnit.Framework;
using System;

namespace StacksAndQueues.Tests
{
    public class QueueViaStacksTests
    {
        [Test]
        public void QueueViaStacks_Pop_WhenEmpty_ThrowsEmptyQueueException()
        {
            // Arrange
            var queueViaStacks = new QueueViaStacks<int>();
            Action action = () => { queueViaStacks.Pop(); };

            // Act && Assert
            action.Should().Throw<EmptyQueueException>().WithMessage("Queue is Empty");
        }

        [Test]
        public void QueueViaStacks_Pop_WhenNotEmpty_ReturnsOldestElements()
        {
            // Arrange
            var queueViaStacks = new QueueViaStacks<int>();
            queueViaStacks.Push(1);
            queueViaStacks.Push(2);
            queueViaStacks.Push(3);
            queueViaStacks.Push(4);
            queueViaStacks.Push(5);

            // Act&Assert
            queueViaStacks.Pop().Should().Be(1);
            queueViaStacks.Pop().Should().Be(2);
            queueViaStacks.Push(6);
            queueViaStacks.Pop().Should().Be(3);
        }

        [Test]
        public void QueueViaStacks_Peek_WhenEmpty_ThrowsEmptyQueueException()
        {
            // Arrange
            var queueViaStacks = new QueueViaStacks<int>();
            Action action = () => { queueViaStacks.Peek(); };

            // Act && Assert
            action.Should().Throw<EmptyQueueException>().WithMessage("Queue is Empty");
        }

        [Test]
        public void QueueViaStacks_Peek_WhenNotEmpty_ReturnsOldestElements()
        {
            // Arrange
            var queueViaStacks = new QueueViaStacks<int>();
            queueViaStacks.Push(1);
            queueViaStacks.Push(2);
            queueViaStacks.Push(3);
            queueViaStacks.Push(4);
            queueViaStacks.Push(5);

            // Act&Assert
            queueViaStacks.Peek().Should().Be(1);
            queueViaStacks.Push(6);
            queueViaStacks.Pop();
            queueViaStacks.Peek().Should().Be(2);
        }

        [Test]
        public void QueueViaStacks_IsEmpty_WhenEmpty_ReturnsTrue()
        {
            // Arrange
            var queueViaStacks = new QueueViaStacks<int>();

            // Act
            var isEmpty = queueViaStacks.IsEmpty();

            // Assert
            isEmpty.Should().BeTrue();
        }
    }
}
