using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace Dynamic.Tests
{
    public class MagicIndexTests
    {
        [Test]
        public void MagicIndex_WhenNoMagicIndexExists_ReturnMinusOne()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            var actual = MagicIndex.MagicIndexAlgo(array);

            // Assert
            actual.Should().Be(-1);
        }

        [Test]
        public void MagicIndex_WhenMagicIndexExists_ReturnCorrectIndex_Case1()
        {
            // Arrange
            var array = new int[] { -40, -10, -5, 0, 1, 2, 3, 7, 10, 20, 40};

            // Act
            var actual = MagicIndex.MagicIndexAlgo(array);

            // Assert
            actual.Should().Be(7);
        }

        [Test]
        public void MagicIndex_WhenMagicIndexExists_ReturnCorrectIndex_Case2()
        {
            // Arrange
            var array = new int[] { -40, -10, -5, 0, 1, 2, 3, 7, 10, 20, 40, 50, 100, 150, 160, 170};

            // Act
            var actual = MagicIndex.MagicIndexAlgo(array);

            // Assert
            actual.Should().Be(7);
        }

        [Test]
        public void MagicIndex_WhenMultipleMagicIndexesExist_ReturnOneCorrectIndex()
        {
            // Arrange
            var array = new int[] { -40, -10, -5, 0, 1, 2, 3, 7, 8, 20, 40 };

            // Act
            var actual = MagicIndex.MagicIndexAlgo(array);

            // Assert
            actual.Should().BeOneOf(new int[] { 7, 8 });
        }

        [Test]
        public void MagicIndexAlgoWithDuplicates_WhenDuplicatesExist_ButNoMagicIndex_ReturnMinusOne()
        {
            // Arrange
            var array = new int[] { -10, 0, 0, 0, 1, 2, 3, 10, 10, 20, 40 };

            // Act
            var actual = MagicIndex.MagicIndexAlgoWithDuplicates(array);

            // Assert
            actual.Should().Be(-1);
        }

        [Test]
        public void MagicIndexAlgoWithDuplicates_WhenDuplicatesExist_MagicIndexExistsInTheFirstHalf_ReturnCorrectMagicIndex()
        {
            // Arrange
            var array = new int[] { -10, 2, 2, 2, 2, 2, 3, 10, 10, 20, 40 };

            // Act
            var actual = MagicIndex.MagicIndexAlgoWithDuplicates(array);

            // Assert
            actual.Should().Be(2);
        }

        [Test]
        public void MagicIndexAlgoWithDuplicates_WhenDuplicatesExist_MagicIndexExistsInTheSecondHalf_ReturnCorrectMagicIndex()
        {
            // Arrange
            var array = new int[] { -10, 0, 1, 2, 2, 7, 7, 8, 8, 20, 40 };

            // Act
            var actual = MagicIndex.MagicIndexAlgoWithDuplicates(array);

            // Assert
            actual.Should().Be(8);
        }
    }
}
