using FluentAssertions;
using NUnit.Framework;

namespace ArraysAndStrings.Tests
{
    public class StringRotationTests
    {
        [Test]
        public void StringRotationAlgoTest()
        {
            StringRotation.StringRotationAlgo("erbottlewat", "waterbottle").Should().BeTrue();
            StringRotation.StringRotationAlgo("erbottlewat", "waterbottl").Should().BeFalse();
            StringRotation.StringRotationAlgo("erbottlewat", "aterbottlew").Should().BeTrue();
            StringRotation.StringRotationAlgo("erbottlewat", "aterbottlewa").Should().BeFalse();
        }
    }
}
