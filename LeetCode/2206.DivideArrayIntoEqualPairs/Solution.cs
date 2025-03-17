using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2206.DivideArrayIntoEqualPairs
{
    public class Solution
    {
        public bool DivideArray(int[] nums)
        {
            // Track unpaired numbers
            HashSet<int> unpaired = [];

            // Add numbers to set if unseen, remove if seen
            foreach (int num in nums)
            {
                if (!unpaired.Remove(num))
                {
                    unpaired.Add(num);
                }
            }

            // Return true if all numbers were paired
            return unpaired.Count == 0;

        }
    }
}
