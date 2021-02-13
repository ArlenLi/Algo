namespace SortingAndSearching
{
    public class RadixSort
    {
        public static int[] RaxdixSortAlgo(int[] input)
        {
            var maxValue = 0;
            foreach(var num in input) 
            {
                if (num > maxValue)
                    maxValue = num;
            }

            var digitPosition = 1;
            while(maxValue / digitPosition > 0)
            {
                var count = new int[10];
                foreach(var num in input)
                {
                    count[num / digitPosition % 10]++;
                }

                var beforeItemsNum = 0;
                for(int i = 0; i < count.Length; i++)
                {
                    var currentItemNum = count[i];
                    count[i] = beforeItemsNum;
                    beforeItemsNum += currentItemNum;
                }

                var result = new int[input.Length];
                foreach(var num in input)
                {
                    result[count[num / digitPosition % 10]] = num;
                    count[num / digitPosition % 10]++;
                }

                input = result;
                digitPosition *= 10;
            }

            return input;
        }
    }
}
