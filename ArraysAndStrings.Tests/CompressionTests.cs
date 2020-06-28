using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class CompressionTests
    {
        [Test]
        public void CompressionAlgoTest()
        {
            Compression.CompressionAlgo("").Should().Be("");
            Compression.CompressionAlgo("aabcccccaaa").Should().Be("a2b1c5a3");
            Compression.CompressionAlgo("AAbCCCCCaaa").Should().Be("A2b1C5a3");
            Compression.CompressionAlgo("AAbCCCCCaaabcqwasdasasdaszczxczx").Should().Be("AAbCCCCCaaabcqwasdasasdaszczxczx");
        }
    }
}
