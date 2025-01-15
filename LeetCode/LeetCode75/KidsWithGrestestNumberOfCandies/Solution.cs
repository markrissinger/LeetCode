using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.KidsWithGrestestNumberOfCandies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();

            int max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                result.Add(candies[i] + extraCandies >= max);
            }

            return result;
        }
    }
}
