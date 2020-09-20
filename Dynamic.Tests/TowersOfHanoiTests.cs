using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic.Tests
{
    public class TowersOfHanoiTests
    {
        [Test]
        public void TowersOfHanoiAlgo_WhenFirstIsEmpty_LastIsEmpty()
        {
            // Arrange
            var first = new Stack<int>();
            var second = new Stack<int>();
            var last = new Stack<int>();

            // Act
            TowersOfHanoi.TowersOfHanoiAlgo(first, second, last);

            // Assert
            last.Should().BeEmpty();
        }

        [Test]
        public void TowersOfHanoiAlgo_WhenFirstContainsOneDisk_LastContainsOne()
        {
            // Arrange
            var first = new Stack<int>();
            first.Push(1);
            var second = new Stack<int>();
            var last = new Stack<int>();
            var expected = new Stack<int>();
            expected.Push(1);

            // Act
            TowersOfHanoi.TowersOfHanoiAlgo(first, second, last);

            // Assert
            last.Count.Should().Be(1);
            last.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TowersOfHanoiAlgo_WhenFirstContainsTwoDisks_LastContainsTwoDisksInOrder()
        {
            // Arrange
            var first = new Stack<int>();
            first.Push(2);
            first.Push(1);
            var second = new Stack<int>();
            var last = new Stack<int>();
            var expected = new Stack<int>();
            expected.Push(2);
            expected.Push(1);

            // Act
            TowersOfHanoi.TowersOfHanoiAlgo(first, second, last);

            // Assert
            last.Count.Should().Be(2);
            last.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void TowersOfHanoiAlgo_WhenFirstContainsTenDisks_LastContainsTenDisksInOrder()
        {
            // Arrange
            var first = new Stack<int>();
            var second = new Stack<int>();
            var last = new Stack<int>();
            var expected = new Stack<int>();
            for(int i = 10; i >=1; i--)
            {
                first.Push(i);
                expected.Push(i);  
            }

            // Act
            TowersOfHanoi.TowersOfHanoiAlgo(first, second, last);

            // Assert
            last.Count.Should().Be(10);
            last.Should().BeEquivalentTo(expected);
        }
    }
}
