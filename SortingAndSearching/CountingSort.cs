namespace SortingAndSearching
{
    public class CountingSort
    {
        public static int[] CountingSortAlgo(int[] input, int maxValue)
        {
            var count = new int[maxValue + 1];
            foreach(var num in input)
            {
                count[num]++;
            }

            var numItemsBefore = 0;
            for(int i = 0; i < count.Length; i++)
            {
                var countForCurrentItem = count[i];
                count[i] = numItemsBefore;
                numItemsBefore += countForCurrentItem;
            }

            var result = new int[input.Length];
            foreach(var num in input)
            {
                result[count[num]] = num;
                count[num]++;
            }
            return result;
        }
    }
}
