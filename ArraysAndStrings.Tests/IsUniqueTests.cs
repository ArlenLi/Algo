using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class IsUniqueTests
    {
        [Test]
        public void IsUniqueUsingArray_Test()
        {
            IsUnique.IsUniqueUsingArray("qwerasdzxco,nkl;p$!@(&*^").Should().BeTrue();
            IsUnique.IsUniqueUsingArray("qwerasdzxcFFo,nklo;p$!@(&*^").Should().BeFalse();
        }

        [Test]
        public void IsUniqueUsingBitVector()
        {
            IsUnique.IsUniqueUsingBitVector("qwerasdzxcoZAIUWPOMCNB").Should().BeTrue();
            IsUnique.IsUniqueUsingBitVector("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ").Should().BeTrue();
            IsUnique.IsUniqueUsingArray("qwerasdzxcoAZAIUWPMPOMCNB").Should().BeFalse();
        }
    }
}
