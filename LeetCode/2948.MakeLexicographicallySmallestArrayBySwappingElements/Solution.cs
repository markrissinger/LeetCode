using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2948.MakeLexicographicallySmallestArrayBySwappingElements
{
    public class Solution
    {
        public int[] LexicographicallySmallestArray(int[] nums, int limit)
        {
            List<int> numsSorted = new List<int> (nums).Order().ToList();

            int currentGroup = 0;
            Dictionary<int, int> numberToGroup = new() { { numsSorted[0], currentGroup } };
            Dictionary<int, LinkedList<int>> groupToList = new() { { currentGroup, new LinkedList<int>(new List<int>() { numsSorted[0] }) } };

            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(numsSorted[i] - numsSorted[i - 1]) > limit)
                {
                    currentGroup++;
                }

                numberToGroup[numsSorted[i]] = currentGroup;

                if (!groupToList.ContainsKey(currentGroup))
                {
                    groupToList[currentGroup] = new LinkedList<int>();
                }
                groupToList[currentGroup].AddLast(numsSorted[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int group = numberToGroup[num];
                nums[i] = groupToList[group].First();
                groupToList[group].RemoveFirst();
            }

            return nums;
        }
    }
}
