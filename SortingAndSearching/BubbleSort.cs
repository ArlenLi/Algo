using System.Linq;

namespace SortingAndSearching
{
    public class BubbleSort
    {
        public static int[] BubbleSortAlgo(int[] input)
        {
            var result = input.ToArray();
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    var temp = result[j];
                    if (result[j] > result[j + 1])
                    {
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            return result;        
        }
    }
}
