using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int numsLength = nums.Length;

            int[] results = new int[numsLength];

            int productSoFar;

            productSoFar = 1;
            for (int i = 0; i < numsLength; i++)
            {
                results[i] = productSoFar;
                productSoFar *= nums[i];
            }

            productSoFar = 1;
            for (int i = numsLength - 1; i >= 0; i--)
            {
                results[i] *= productSoFar;
                productSoFar *= nums[i];
            }

            return results;
        }
    }
}
