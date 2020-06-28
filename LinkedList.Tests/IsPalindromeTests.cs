using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace LinkedList.Tests
{
    public class IsPalindromeTests
    {
        [Test]       
        public void IsPalindromeReverseAlgoTest_WhenInputIsOddLengthPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1);

            // Act
            var result = IsPalindrome.IsPalindromeReverseAlgo(node);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void IsPalindromeRecursiveAlgoTest_WhenInputIsOddLengthPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1);

            // Act
            var result = IsPalindrome.IsPalindromRecursiveAlgo(node);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void IsPalindromeReverseAlgoTest_WhenInputIsEvenLengthPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1);

            // Act
            var result = IsPalindrome.IsPalindromeReverseAlgo(node);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void IsPalindromeRecursiveAlgoTest_WhenInputIsEvenLengthPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1);

            // Act
            var result = IsPalindrome.IsPalindromRecursiveAlgo(node);

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void IsPalindromeReverseAlgoTest_WhenInputIsNotPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1).AppendToTail(5);

            // Act
            var result = IsPalindrome.IsPalindromeReverseAlgo(node);

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void IsPalindromeRecursiveAlgoTest_WhenInputIsNotPalindrome()
        {
            // Assert
            var node = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(4).AppendToTail(3).AppendToTail(2).AppendToTail(1).AppendToTail(5);

            // Act
            var result = IsPalindrome.IsPalindromRecursiveAlgo(node);

            // Assert
            result.Should().BeFalse();
        }
    }
}
