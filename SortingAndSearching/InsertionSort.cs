using System.Linq;

namespace SortingAndSearching
{
    public class InsertionSort
    {
        public static int[] InsertionSortAlgo(int[] input)
        {
            var result = input.ToArray();
            for(int i = 0; i < result.Length; i++)
            {
                var j = i;
                var value = result[i];
                while(j > 0 && result[j - 1] > value)
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = value;
            }
            return result;
        }
    }
}
