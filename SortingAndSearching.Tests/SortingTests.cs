using FluentAssertions;
using NUnit.Framework;
using System;
using System.Linq;

namespace SortingAndSearching.Tests
{
    public class Tests
    {
        [Test]
        public void SortingTests()
        {
            // Arrange
            var input = new int[] { 30, -20, 66, 1, 0, -666, 888, 33, 999 };
            //var expected = new int[] { -666, -20, 0, 1, 30, 33, 66, 888, 999 };

            // Act & Assert
            BubbleSort.BubbleSortAlgo(input.ToArray()).Should().BeInAscendingOrder();
        }
    }
}