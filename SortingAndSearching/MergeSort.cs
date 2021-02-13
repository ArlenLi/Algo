using System.Linq;

namespace SortingAndSearching
{
    public class MergeSort
    {
        public static int[] MergeSortAlgo(int[] input)
        {
            var result = input.ToArray();
            MergeSortAlgo(0, input.Length - 1, result);
            return result;
        }

        private static void MergeSortAlgo(int low, int high, int[] result)
        {
            if(low < high)
            {
                var mid = (low + high) / 2;
                MergeSortAlgo(low, mid, result);
                MergeSortAlgo(mid + 1, high, result);
                Merge(low, mid, high, result);
            }
        }

        private static void Merge(int low, int mid, int high, int[] result)
        {
            var temp = new int[high - low + 1];
            var tempIndex = 0;
            var leftIndex = low;
            var rightIndex = mid + 1;
            while (leftIndex <= mid && rightIndex <= high)
            {
                temp[tempIndex++] = result[leftIndex] < result[rightIndex] ? result[leftIndex++] : result[rightIndex++];
            }
            while(leftIndex <= mid)
            {
                temp[tempIndex++] = result[leftIndex++];
            }
            while(rightIndex <= high)
            {
                temp[tempIndex++] = result[rightIndex++];
            }
            for(int k = 0; k < temp.Length; k++)
            {
                result[low + k] = temp[k];
            }
        }
    }
}
