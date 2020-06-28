using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class OneAwayTests
    {
        [Test]
        public void OneAwayAlgoTests() {
            OneAway.OneAwayAlgo("pale", "ple").Should().BeTrue();
            OneAway.OneAwayAlgo("pales", "pale").Should().BeTrue();
            OneAway.OneAwayAlgo("pale", "bale").Should().BeTrue();
            OneAway.OneAwayAlgo("pale", "bake").Should().BeFalse();
        }
    }
}
