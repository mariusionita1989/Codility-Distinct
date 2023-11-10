using System.Runtime.CompilerServices;

namespace Codility_Distinct
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                HashSet<int> distinctValues = new HashSet<int>();
                foreach (int num in A)
                    distinctValues.Add(num);
                return distinctValues.Count;
            }

            return -1;
        }
    }
}
