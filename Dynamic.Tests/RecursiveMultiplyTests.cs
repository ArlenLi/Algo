using FluentAssertions;
using NUnit.Framework;

namespace Dynamic.Tests
{
    public class RecursiveMultiplyTests
    {
        [Test]
        [TestCase(6, 3, 18)]
        [TestCase(7, 9, 63)]
        [TestCase(25,25,625)]
        [TestCase(25,1,25)]
        [TestCase(0,3,0)]
        public void RecursiveMultiplyAlgo_GivenInput_ReturnCorrectResult(int integer1, int integer2, int expected)
        {
            // Act
            var actual = RecursiveMultiply.RecursiceMultiplyAlgo(integer1, integer2);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
