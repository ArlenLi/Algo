using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic.Tests
{
    public class PowerSetTests
    {
        [Test]
        public void PowerSetAlgo_WhenSetIsEmpty_SubsetsShouldOnlyCotainsOneEmptySet() 
        {
            // Act
            var actual = PowerSet<char>.PowerSetAlgo(new HashSet<char>());

            // Assert
            actual.Count.Should().Be(1);
            actual[0].Count.Should().Be(0);
        }

        [Test]
        public void PowerSetAlgo_WhenSetIsNotEmpty_ReturnCorrectSubsets()
        {
            // Arrange
            var expected = new List<HashSet<char>>();
            expected.Add(new HashSet<char>());
            expected.Add(new HashSet<char>() {'a'});
            expected.Add(new HashSet<char>() {'b'});
            expected.Add(new HashSet<char>() {'c'});
            expected.Add(new HashSet<char>() {'a', 'b'});
            expected.Add(new HashSet<char>() {'a', 'c'});
            expected.Add(new HashSet<char>() {'b', 'c'});
            expected.Add(new HashSet<char>() {'a', 'b', 'c'});
            
            // Act
            var actual = PowerSet<char>.PowerSetAlgo(new HashSet<char>(new char[]{ 'a', 'b', 'c'}));

            // Assert
            actual.Count.Should().Be(8);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
