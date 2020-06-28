using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class URLifyTests
    {
        [Test]
        public void URLify_Tests()
        {
            var input = new char[100];
            var inputString = "Mr John Smith";
            for (int i = 0; i < inputString.Length; i++)
                input[i] = inputString[i];

            var result = URLify.URLifyAlgo(input, 13);
            (new string(result)).TrimEnd('\0').Should().Be("Mr%20John%20Smith");
        }
    }
}
