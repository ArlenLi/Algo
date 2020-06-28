using FluentAssertions;
using NUnit.Framework;
using System;
using System.Threading;

namespace StacksAndQueues.Tests
{
    public class MinStackTests
    {
        [Test]
        public void MinStack_Pop_WhenStackIsEmpty_ThrowsEmptyStackException()
        {
            // Arrange
            var stack = new MinStack<int>();
            Action action = () => { stack.Pop(); };

            // Act & Assert
            action.Should().Throw<EmptyStackException>();
        }

        [Test]
        public void MinStack_Pop_WhenStackIsNotEmpty_ReturnsLastPushedItem()
        {
            // Arrange
            var stack = new MinStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            var lastPushedItem = stack.Pop();
            var secondLastPushedItem = stack.Pop();

            // Assert
            lastPushedItem.Should().Be(5);
            secondLastPushedItem.Should().Be(4);
        }

        [Test]
        public void MinStack_Peek_WhenStackIsEmpty_ThrowsEmptyStackException()
        {
            // Arrange
            var stack = new MinStack<int>();
            Action action = () => { stack.Peek(); };

            // Act & Assert
            action.Should().Throw<EmptyStackException>();
        }

        [Test]
        public void MinStack_Peek_WhenStackIsNotEmpty_ReturnsLastPushedItem()
        {
            // Arrange
            var stack = new MinStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            var actual = stack.Peek();

            // Assert
            actual.Should().Be(5);
        }

        [Test]
        public void MinStack_Min_WhenStackIsEmpty_ThrowsEmptyStackException()
        {
            // Arrange
            var stack = new MinStack<int>();
            Action action = () => { stack.Min(); };

            // Act & Assert
            action.Should().Throw<EmptyStackException>();
        }

        [Test]
        public void MinStack_Min_WhenStackIsNotEmpty_ShouldReturnMinimunItem()
        {
            // Arrange
            var stack = new MinStack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            // Act
            var minimum = stack.Min();
            stack.Pop();
            var minimumAfterPop = stack.Min();

            // Assert
            minimum.Should().Be(1);
            minimumAfterPop.Should().Be(2);
        }
    }
}