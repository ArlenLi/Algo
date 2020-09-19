using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic.Tests
{
    public class TripleStepTests
    {
        [Test]
        public void TripleStep_WhenStepsIs3_ThereShouldBe4Ways()
        {
            // Act
            var result = TripleStep.TripleStepAlgo(3);

            // Assert
            result.Should().Be(4);
        }

        [Test]
        public void TripleStep_WhenStepsIs6_ThereShouldBe24Ways()
        {
            // Act
            var result = TripleStep.TripleStepAlgo(6);

            // Assert
            result.Should().Be(24);
        }
    }
}
