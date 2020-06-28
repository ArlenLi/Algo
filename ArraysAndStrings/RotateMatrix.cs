using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArraysAndStrings
{
    public class RotateMatrix
    {
        public static short[,] RotateMatrixAlgo(short[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentException("Lenth of two dimensions are not equal");
            var length = matrix.GetLength(0);
            var start = 0;
            var end = matrix.GetLength(0) - 1;
            var offset = 0;

            for (int i = 0; i < matrix.GetLength(0)/2; i++)
            {
                start = 0 + offset;
                end = matrix.GetLength(0) - 1 - offset;

                for(int j = start; j < end; j++)
                {
                    var top = matrix[i, j];
                    matrix[i, j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = top;
                }

                offset++;
            }
            return matrix;
        }
    }
}
