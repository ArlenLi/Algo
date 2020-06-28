using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class PalindromePermutationTests
    {
        [Test]
        public void PalindromePermutation_Test()
        {
            PalindromePermutation.PalindromePermutationAlgo("TactCoa").Should().BeTrue();
            PalindromePermutation.PalindromePermutationAlgo("TactCoaa").Should().BeFalse();
            PalindromePermutation.PalindromePermutationAlgo("xReowtaoraewX").Should().BeTrue();
        }
    }
}
