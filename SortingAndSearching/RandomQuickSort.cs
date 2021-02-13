using System;
using System.Linq;

namespace SortingAndSearching
{
    public class RandomQuickSort
    {
        public static int[] RandomQuickSortAlgo(int[] input)
        {
            var result = input.ToArray();
            RandomQuickSortAlgoDivide(0, input.Length - 1, result);
            return result;
        }

        private static void RandomQuickSortAlgoDivide(int low, int high, int[] input)
        {
            var pivotIndex = Partition(low, high, input);
            if (low < pivotIndex - 1)
                RandomQuickSortAlgoDivide(low, pivotIndex - 1, input);
            if (pivotIndex + 1 < high)
                RandomQuickSortAlgoDivide(pivotIndex + 1, high, input);
        }

        private static int Partition(int low, int high, int[] input)
        {
            var random = new Random();
            var randomIndex = random.Next(low, high + 1);
            Swap(low, randomIndex, input);
            var pivotIndex = low + 1;
            for(int k = low + 1; k <= high; k++)
            {
                if(input[k] < input[low])
                {
                    Swap(pivotIndex, k, input);
                    pivotIndex++;
                }
            }
            Swap(low, pivotIndex - 1, input); 
            return pivotIndex - 1;
        }

        private static void Swap(int firstIndex, int secondIndex, int[] input)
        {
            var temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }
    }
}
