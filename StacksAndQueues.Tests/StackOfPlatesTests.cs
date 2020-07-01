using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Tests
{
    public class StackOfPlatesTests
    {
        [Test]
        public void StackOfPlates_Pop_WhenEmpty_ThrowsEmptyStackException()
        {
            // Arrange
            var stackOfPlates = new StackOfPlates<int>(3);
            Action action = () => { stackOfPlates.Pop(); };

            // Act && Assert
            action.Should().Throw<EmptyStackException>().WithMessage("Stack is Empty");
        }

        [Test]
        public void StackOfPlates_Pop_WhenNotEmpty_ShouldReturnTopOfCurrentPlate()
        {
            // Arrange
            var stackOfPlates = new StackOfPlates<int>(3);
            stackOfPlates.push(1);
            stackOfPlates.push(2);
            stackOfPlates.push(3);
            stackOfPlates.push(4);

            // Act && Assert
            stackOfPlates.Pop().Should().Be(4);
            stackOfPlates.Pop().Should().Be(3);
            stackOfPlates.Pop().Should().Be(2);
            stackOfPlates.Pop().Should().Be(1);
        }

        [Test]
        public void StackOfPlates_PopAt_WhenIndexIsGreaterThanCurrentStackIndex_ThrowsException()
        {
            // Arrange
            var stackOfPlates = new StackOfPlates<int>(3);
            stackOfPlates.push(1);
            stackOfPlates.push(2);
            stackOfPlates.push(3);
            stackOfPlates.push(4);
            Action action = () => { stackOfPlates.PopAt(2); };

            // Act && Assert
            action.Should().Throw<InvalidOperationException>().WithMessage("The specified stack does not exist");
        }

        [Test]
        public void StackOfPlates_PopAt_WhenEmpty_ThrowsException()
        {
            // Arrange
            var stackOfPlates = new StackOfPlates<int>(3);
            Action action = () => { stackOfPlates.PopAt(0); };

            // Act && Assert
            action.Should().Throw<InvalidOperationException>().WithMessage("The specified stack is empty");
        }

        [Test]
        public void StackOfPlates_PopAt_whenNotEmpty_AndIndexIsValid_ReturnsTopOfSpecifiedStack()
        {
            // Arrange
            var stackOfPlates = new StackOfPlates<int>(3);
            stackOfPlates.push(1);
            stackOfPlates.push(2);
            stackOfPlates.push(3);
            stackOfPlates.push(4);
            stackOfPlates.push(5);
            stackOfPlates.push(6);
            stackOfPlates.push(7);
            stackOfPlates.push(8);
            stackOfPlates.push(9);
            stackOfPlates.push(10);

            // Act && Assert
            stackOfPlates.PopAt(0).Should().Be(3);           
            stackOfPlates.PopAt(0).Should().Be(4);
            stackOfPlates.PopAt(1).Should().Be(8);
            stackOfPlates.PopAt(2).Should().Be(10);
        }
    }
}
