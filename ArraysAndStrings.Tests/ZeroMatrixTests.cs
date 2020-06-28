using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class ZeroMatrixTests
    {
        [Test]
        public void ZeroMatrixTest1()
        {
            var input = new int[4,4];
            input[0,0] = 1;
            input[0,1] = 1;
            input[0,2] = 1;
            input[0,3] = 1;
            input[1,0] = 1;
            input[1,1] = 0;
            input[1,2] = 1;
            input[1,3] = 1;
            input[2, 0] = 1;
            input[2, 1] = 1;
            input[2, 2] = 1;
            input[2, 3] = 0;
            input[3, 0] = 1;
            input[3, 1] = 1;
            input[3, 2] = 0;
            input[3, 3] = 1;

            var result = ZeroMatrix.ZeroMatricAlgo(input);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                        result[i, j].Should().Be(1);
                    else
                        result[i, j].Should().Be(0);
                }
        }
        [Test]
        public void ZeroMatrixTest2()
        {
            var input = new int[4, 4];
            input[0, 0] = 0;
            input[0, 1] = 1;
            input[0, 2] = 1;
            input[0, 3] = 1;
            input[1, 0] = 1;
            input[1, 1] = 1;
            input[1, 2] = 1;
            input[1, 3] = 1;
            input[2, 0] = 1;
            input[2, 1] = 1;
            input[2, 2] = 1;
            input[2, 3] = 1;
            input[3, 0] = 1;
            input[3, 1] = 1;
            input[3, 2] = 0;
            input[3, 3] = 1;

            var result = ZeroMatrix.ZeroMatricAlgo(input);
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (i == 1 && j == 1)
                        result[i, j].Should().Be(1);
                    else if (i == 1 && j == 3)
                        result[i, j].Should().Be(1);
                    else if (i == 2 && j == 1)
                        result[i, j].Should().Be(1);
                    else if (i == 2 && j == 3)
                        result[i, j].Should().Be(1);
                    else
                        result[i, j].Should().Be(0);
                }
        }
    }
}
