namespace Dynamic
{
    public class RecursiveMultiply
    {
        public static int RecursiceMultiplyAlgo(int integer1, int integer2)
        {
            var greater = integer1 >= integer2 ? integer1 : integer2;
            var smaller = integer1 < integer2 ? integer1 : integer2;

            if(smaller == 0)
            {
                return 0;
            }
            
            if(smaller == 1)
            {
                return greater;
            }

            if(smaller % 2 == 0)
            {
                var halfResult = RecursiceMultiplyAlgo(greater, smaller / 2);
                return halfResult + halfResult;
            }
            else
            {
                var roughlyHalfResult = RecursiceMultiplyAlgo(greater, smaller / 2);
                return roughlyHalfResult + roughlyHalfResult + greater;
            }           
        }
    }
}
