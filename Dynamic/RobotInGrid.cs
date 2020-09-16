
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    public class RobotInGrid
    {
        /*
         * Robot in a Grid: Imagine a robot sitting on the upper left corner of grid with r rows and c columns.
         * The robot can only move in two directions, right and down, but certain cells are "off limits" such that
         * the robot cannot step on them. Design an algorithm to find a path for the robot from the top left to
         * the bottom right.
         */
        public static IList<List<string>> RobotInGridAlgo(bool[,] grid)
        {
            var results = new List<List<string>>();
            var row = grid.GetLength(0) - 1;
            var column = grid.GetLength(1) - 1;
            if(grid[row, column])
            {
                var possiblePath = new List<string>();
                possiblePath.Add(row + "," + column);
                FindPossiblePathFromOriginToTarget(row, column, grid, possiblePath, results);
                
            }
            return results;
        }

        private static void FindPossiblePathFromOriginToTarget(int targetX, int targetY, bool[,] grid, IList<string> possiblePath, IList<List<string>> results)
        {
            if(targetX < 0 || targetY < 0 || !grid[targetX, targetY])
            {
                return;
            }
            else if(targetX == 0 && targetY == 0)
            {
                results.Add(possiblePath.Reverse().ToList());
                return;
            }
            else
            {
                var cell = --targetX + "," + targetY;
                possiblePath.Add(cell);
                FindPossiblePathFromOriginToTarget(targetX, targetY, grid, possiblePath, results);
                possiblePath.Remove(cell);
                targetX++;

                cell = targetX + "," + --targetY;
                possiblePath.Add(cell);
                FindPossiblePathFromOriginToTarget(targetX, targetY, grid, possiblePath, results);
                possiblePath.Remove(cell);
                targetY++;
            }
        }
    }
}
