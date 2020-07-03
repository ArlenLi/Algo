using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Tests
{
    public class SortStackTests
    {
        [Test]
        public void SortStackAlgo_EmptyStack_ShouldReturnEmptyStack()
        {
            // Arrange
            var stackToBeSorted = new Stack<int>();

            // Act
            var sortedStack = SortStack<int>.SortStackAlgo(stackToBeSorted);

            // Assert
            sortedStack.IsEmpty().Should().BeTrue();
        }

        [Test]
        public void SortStackAlgo_NonEmptyStack_ShouldReturnSortedStack()
        {
            // Arrange
            var stackToBeSorted = new Stack<int>();
            stackToBeSorted.Push(1);
            stackToBeSorted.Push(2);
            stackToBeSorted.Push(3);
            stackToBeSorted.Push(5);
            stackToBeSorted.Push(4);
            stackToBeSorted.Push(6);
            stackToBeSorted.Push(7);
            stackToBeSorted.Push(9);
            stackToBeSorted.Push(8);

            // Act
            var sortedStack = SortStack<int>.SortStackAlgo(stackToBeSorted);

            // Assert
            for(int i = 1; i <=9; i++)
            {
                sortedStack.Pop().Should().Be(i);
            }
            sortedStack.IsEmpty().Should().BeTrue();

        }



    }
}
