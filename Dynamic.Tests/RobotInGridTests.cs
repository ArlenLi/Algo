using FluentAssertions;
using NUnit.Framework;

namespace Dynamic.Tests
{
    public class RobotInGridTests
    {
        [Test]
        public void RobotInGrid_WhenThereIsNoAvailablePaths_ReturnEmptyLists()
        {
            // Arrange
            var grid = new bool[5, 5];

            // Act
            var result = RobotInGrid.RobotInGridAlgo(grid);

            // Assert
            result.Should().BeEmpty();
        }

        [Test]
        public void RobotInGrid_WhenThereIsOnlyOneAvailablePath_ReturnListsContainOnePath()
        {
            // Arrange
            var grid = new bool[5, 5];
            grid[0, 0] = true;
            grid[0, 1] = true;
            grid[0, 2] = true;
            grid[0, 3] = true;
            grid[0, 4] = true;
            grid[1, 4] = true;
            grid[2, 4] = true;
            grid[3, 4] = true;
            grid[4, 4] = true;

            // Act
            var result = RobotInGrid.RobotInGridAlgo(grid);

            // Assert
            result.Count.Should().Be(1);
            var path = string.Join(";", result[0]);
            path.Should().Be("0,0;0,1;0,2;0,3;0,4;1,4;2,4;3,4;4,4");
        }

        [Test]
        public void RobotInGrid_WhenThereAreTwoAvailablePaths_ReturnEmptyLists()
        {
            // Arrange
            var grid = new bool[5, 5];
            grid[0, 0] = true;
            grid[0, 1] = true;
            grid[0, 2] = true;
            grid[0, 3] = true;
            grid[0, 4] = true;
            grid[1, 4] = true;
            grid[2, 4] = true;
            grid[3, 4] = true;
            grid[4, 4] = true;

            grid[1, 0] = true;
            grid[2, 0] = true;
            grid[3, 0] = true;
            grid[4, 0] = true;
            grid[4, 1] = true;
            grid[4, 2] = true;
            grid[4, 3] = true;            

            // Act
            var result = RobotInGrid.RobotInGridAlgo(grid);

            // Assert
            result.Count.Should().Be(2);
            var path1 = string.Join(";", result[0]);
            path1.Should().Be("0,0;0,1;0,2;0,3;0,4;1,4;2,4;3,4;4,4");
            var path2 = string.Join(";", result[1]);
            path2.Should().Be("0,0;1,0;2,0;3,0;4,0;4,1;4,2;4,3;4,4");
        }
    }
}