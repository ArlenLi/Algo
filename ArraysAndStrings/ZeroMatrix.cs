using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ArraysAndStrings
{
    public class ZeroMatrix
    {
        /* 1.8
         * Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
           column are set to O.
         */
        public static int[,] ZeroMatricAlgo(int[,] input)
        {
            var shouldFirstRowBeSetToZero = false;
            var shouldFirstColumnBeSetToZero = false;
            for (int i = 0; i < input.GetLength(1); i++) {
                if (input[0,i] == 0)
                    shouldFirstRowBeSetToZero = true;
            }
            for(int i = 0; i < input.GetLength(0); i++)
            {
                if (input[i,0] == 0)
                    shouldFirstColumnBeSetToZero = true;
            }

            for(int i = 1; i < input.GetLength(0); i++)
                for(int j = 1; j < input.GetLength(1); j++)
                {
                    if(input[i, j] == 0)
                    {
                        input[i, 0] = 0;
                        input[0, j] = 0;
                    }
                }

            for(int i = 1; i < input.GetLength(1); i++)
            {
                if(input[0, i] == 0)
                {
                    for (int j = 1; j < input.GetLength(0); j++)
                        input[j, i] = 0;
                }
            }

            for(int i = 1; i < input.GetLength(0); i++)
            {
                if(input[i, 0] == 0)
                {
                    for (int j = 1; j < input.GetLength(1); j++)
                        input[i, j] = 0;
                }
            }

            if(shouldFirstRowBeSetToZero)
            {
                for (int i = 0; i < input.GetLength(1); i++)
                    input[0, i] = 0;
            }
            if (shouldFirstColumnBeSetToZero)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                    input[i, 0] = 0;
            }
            return input;
        }
    }
}
