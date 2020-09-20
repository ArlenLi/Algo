namespace SortingAndSearching
{
    public class BubbleSort
    {
        public static int[] BubbleSortAlgo(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
                for (int j = 0; j < unsortedArray.Length - 1 - i; j++)
                {
                    var temp = unsortedArray[j];
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = temp;
                    }
                }
            return unsortedArray;        
        }
    }
}
