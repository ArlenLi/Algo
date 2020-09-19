using System;
using System.Globalization;

namespace Dynamic
{
    /*
     * Magic Index: A magic index in an array A [e ... n -1] is defined to be an index such that A[ i] =
     * i. Given a sorted array of distinct integers, write a method to find a magic index, if one exists, in
     * array A.
     */
    public class MagicIndex
    {
        public static int MagicIndexAlgo(int[] array)
        {
            return MagicIndexAlgo(0, array.Length, array);
        }

        private static int MagicIndexAlgo(int low, int high, int[] array)
        {
            if (low > high)
                return -1;
            var mid = (low + high) / 2;
            if(array[mid] == mid)
            {
                return mid;
            }
            else if(array[mid] > mid)
            {
                return MagicIndexAlgo(low, mid - 1, array);
            }
            else
            {
                return MagicIndexAlgo(mid + 1, high, array);
            }
        }

        public static int MagicIndexAlgoWithDuplicates(int[] array)
        {
            return MagicIndexAlgoWithDuplicates(0, array.Length, array);
        }

        private static int MagicIndexAlgoWithDuplicates(int low, int high, int[] array)
        {
            if (low > high)
            {
                return -1;
            }
            var mid = (low + high) / 2;
            var midValue = array[mid];

            if(mid == midValue)
            {
                return mid;
            }

            var searchLeftResult = MagicIndexAlgoWithDuplicates(low, Math.Min(mid - 1, midValue) , array);
            var searchRightResult = MagicIndexAlgoWithDuplicates(Math.Max(mid + 1, midValue), high, array);

            return searchLeftResult != -1 ? searchLeftResult : searchRightResult;
        }
    }
}
