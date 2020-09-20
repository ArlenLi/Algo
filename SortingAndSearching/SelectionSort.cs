using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearching
{
    public class SelectionSort
    {
        public static int[] SelectionSortAlgo(int[] input)
        {
            var result = input.ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                var currentSmallestIndex = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if(result[j] < result[currentSmallestIndex])
                    {
                        currentSmallestIndex = j;
                    }
                }
                if(currentSmallestIndex != i)
                {
                    var temp = result[currentSmallestIndex];
                    result[currentSmallestIndex] = result[i];
                    result[i] = temp;
                }
            }
            return result;
        }
    }
}
