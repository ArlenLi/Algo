using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class CheckPermutationTests
    {
        [Test]
        public void CheckPermutationUsingArray_Tests()
        {
            CheckPermutation.CheckPermutationUsingArray("adasdasdasd", "adasdasdasda").Should().BeFalse();
            CheckPermutation.CheckPermutationUsingArray("adasdasdasd", "adasdasdasd").Should().BeTrue();
        }

        [Test]
        public void CheckPermutationUsingSorting_Tests()
        {
            CheckPermutation.CheckPermutationUsingSorting("adasdasdasd", "adasdasdasda").Should().BeFalse();
            CheckPermutation.CheckPermutationUsingSorting("adasdasdasd", "adasdasdasd").Should().BeTrue();
        }
    }
}
