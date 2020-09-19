namespace Dynamic
{
    /*
     * Triple Step: A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3
     * steps at a time. Implement a method to count how many possible ways the child can run up the
     * stairs.
     */
    public class TripleStep
    {
        public static int TripleStepAlgo(int steps)
        {
            if (steps == 0 || steps == 1 || steps == 2)
                return steps;
            
            var temp = new int[steps + 1];
            temp[1] = 1;
            temp[2] = 2;
            temp[3] = 4;
            return CalculatePossibleWays(steps, temp);
        }

        private static int CalculatePossibleWays(int steps, int[] temp)
        {
            if(temp[steps] == 0)
            {
                temp[steps] = CalculatePossibleWays(steps - 1, temp) + CalculatePossibleWays(steps - 2, temp) + CalculatePossibleWays(steps - 3, temp);
            }

            return temp[steps];
        }
    }
}
