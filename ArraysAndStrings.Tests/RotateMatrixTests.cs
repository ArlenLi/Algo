using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ArraysAndStrings.Tests
{
    public class RotateMatrixTests
    {
        [Test]
        public void RotateMatrixTest() {
            var input = new short[5, 5];
            input[0, 0] = (short)1;
            input[0, 1] = (short)2;
            input[0, 2] = (short)3;
            input[0, 3] = (short)4;
            input[0, 4] = (short)5;
            input[1, 0] = (short)6;
            input[1, 1] = (short)7;
            input[1, 2] = (short)8;
            input[1, 3] = (short)9;
            input[1, 4] = (short)10; 
            input[2, 0] = (short)11;
            input[2, 1] = (short)12;
            input[2, 2] = (short)13;
            input[2, 3] = (short)14;
            input[2, 4] = (short)15; 
            input[3, 0] = (short)16;
            input[3, 1] = (short)17;
            input[3, 2] = (short)18;
            input[3, 3] = (short)19;
            input[3, 4] = (short)20; 
            input[4, 0] = (short)21;
            input[4, 1] = (short)22;
            input[4, 2] = (short)23;
            input[4, 3] = (short)24;
            input[4, 4] = (short)25;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    Debug.Write(input[i, j] + " ");
                }
                Debug.WriteLine(null);
            }


            var result = RotateMatrix.RotateMatrixAlgo(input);

            Debug.WriteLine(null);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    Debug.Write(result[i, j] + " ");
                }
                Debug.WriteLine(null);
            }
            result[0, 0].Should().Be(21);
            result[0, 1].Should().Be(16);
            result[0, 2].Should().Be(11);
            result[0, 3].Should().Be(6);
            result[0, 4].Should().Be(1);
            result[1, 0].Should().Be(22);
            result[1, 1].Should().Be(17);
            result[1, 2].Should().Be(12);
            result[1, 3].Should().Be(7);
            result[1, 4].Should().Be(2); 
            result[2, 0].Should().Be(23);
            result[2, 1].Should().Be(18);
            result[2, 2].Should().Be(13);
            result[2, 3].Should().Be(8);
            result[2, 4].Should().Be(3); 
            result[3, 0].Should().Be(24);
            result[3, 1].Should().Be(19);
            result[3, 2].Should().Be(14);
            result[3, 3].Should().Be(9);
            result[3, 4].Should().Be(4); 
            result[4, 0].Should().Be(25);
            result[4, 1].Should().Be(20);
            result[4, 2].Should().Be(15);
            result[4, 3].Should().Be(10);
            result[4, 4].Should().Be(5); 
        }
    }
}
