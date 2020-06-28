using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Tests
{
    public class LoopDetectionTests
    {
        [Test]
        public void LoopDetectionAlgo_WhenLinkedListIsNonLoop_ReturnNull()
        {
            // Arrange
            var nonLoopLinkedList = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(5);

            // Act
            var actual = LoopDetection.LoopDetectionAlgo(nonLoopLinkedList);

            // Assert
            actual.Should().Be(null);
        }

        [Test]
        public void LoopDetectionAlgo_WhenLoopSizeLessThanStepsBetweenHeadAndLoopStartingNode_ReturnCorrectLoopStartingNode()
        {
            // Arrange
            var loopStartingNode = new Node(9);
            var loopSizeLessThanStepsBetweenHeadAndLoopStartingNodeLinkedList = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4)
                .AppendToTail(5).AppendToTail(6).AppendToTail(7).AppendToTail(loopStartingNode).AppendToTail(8).AppendToTail(11).AppendToTail(loopStartingNode);

            // Act
            var actual = LoopDetection.LoopDetectionAlgo(loopSizeLessThanStepsBetweenHeadAndLoopStartingNodeLinkedList);

            // Assert
            Object.ReferenceEquals(actual, loopStartingNode).Should().BeTrue();
        }

        [Test]
        public void LoopDetectionAlgo_WhenLoopSizeGreaterThanStepsBetweenHeadAndLoopStartingNode_ReturnCorrectLoopStartingNode()
        {
            // Arrange
            var loopStartingNode = new Node(9);
            var LoopSizeGreaterThanStepsBetweenHeadAndLoopStartingNodeLinkedList = new Node(1).AppendToTail(2).AppendToTail(loopStartingNode).AppendToTail(3).AppendToTail(4)
                .AppendToTail(5).AppendToTail(6).AppendToTail(7).AppendToTail(8).AppendToTail(11).AppendToTail(loopStartingNode);

            // Act
            var actual = LoopDetection.LoopDetectionAlgo(LoopSizeGreaterThanStepsBetweenHeadAndLoopStartingNodeLinkedList);

            // Assert
            Object.ReferenceEquals(actual, loopStartingNode).Should().BeTrue();
        }

        [Test]
        public void LoopDetectionAlgo_WhenLoopSizeEqualsToStepsBetweenHeadAndLoopStartingNode_ReturnCorrectLoopStartingNode()
        {
            // Arrange
            var loopStartingNode = new Node(9);
            var LoopSizeEqualsToStepsBetweenHeadAndLoopStartingNodeLinkedList = new Node(1).AppendToTail(2).AppendToTail(3).AppendToTail(4).AppendToTail(loopStartingNode)
                .AppendToTail(5).AppendToTail(6).AppendToTail(7).AppendToTail(8).AppendToTail(loopStartingNode);

            // Act
            var actual = LoopDetection.LoopDetectionAlgo(LoopSizeEqualsToStepsBetweenHeadAndLoopStartingNodeLinkedList);

            // Assert
            Object.ReferenceEquals(actual, loopStartingNode).Should().BeTrue();
        }
    }
}
