using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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

            // Act & Assert
            BubbleSort.BubbleSortAlgo(input).Should().BeInAscendingOrder();
            SelectionSort.SelectionSortAlgo(input).Should().BeInAscendingOrder();
            InsertionSort.InsertionSortAlgo(input).Should().BeInAscendingOrder();
            MergeSort.MergeSortAlgo(input).Should().BeInAscendingOrder();
            RandomQuickSort.RandomQuickSortAlgo(input).Should().BeInAscendingOrder();
        }

        [Test]
        public void CountingSortTest()
        {
            // Arrange
            var input = new int[] { 0, 5, 5, 7, 2, 1, 3, 8, 9, 1, 10 };

            // Act & Assert
            CountingSort.CountingSortAlgo(input, 10).Should().BeInAscendingOrder();
        }

        [Test]
        public void RadixSortTest()
        {
            // Arrange
            var input = new int[] { 0, 15, 200, 3, 55555, 66666, 222, 888, 666, 9999, 12345893, 68478512, 6317521 };
            var actual = RadixSort.RaxdixSortAlgo(input);

            // Act & Assert
            actual.Should().BeInAscendingOrder();
        }
    }
}