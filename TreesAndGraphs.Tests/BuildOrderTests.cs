using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs.Tests
{
    public class BuildOrderTests
    {
        [Test]
        public void BuildOderAlgo_WhenThereIsAWayToBuildProjects_ReturnValidBuildOrder()
        {
            // Arrange
            var projects = new string[] { "a", "b", "c", "d", "e", "f" };
            var dependencies = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("a", "d"),
                new Tuple<string, string>("f", "b"),
                new Tuple<string, string>("b", "d"),
                new Tuple<string, string>("f", "a"),
                new Tuple<string, string>("d", "c"),
            };

            // Act
            var actual = BuildOrder.BuildOderAlgo(projects, dependencies);

            // Assert
            actual.Should().NotBeNull();
        }

        [Test]
        public void BuildOderAlgo_WhenThereIsNoWayToBuildProjects_ReturnNull()
        {
            // Arrange
            var projects = new string[] { "a", "b", "c", "d", "e", "f" };
            var dependencies = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("a", "d"),
                new Tuple<string, string>("f", "b"),
                new Tuple<string, string>("b", "d"),
                new Tuple<string, string>("f", "a"),
                new Tuple<string, string>("d", "c"),
                new Tuple<string, string>("c", "b")
            };

            // Act
            var actual = BuildOrder.BuildOderAlgo(projects, dependencies);

            // Assert
            actual.Should().BeNull();
        }
    }
}
