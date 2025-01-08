using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CombinationSumII
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();

            // sort ascending
            Array.Sort(candidates);

            Backtrack(result, new List<int>(), candidates, target, 0);

            return result;
        }

        private static void Backtrack(IList<IList<int>> answer, IList<int> currentCombination, int[] candidates,  int totalRemaining, int index)
        {
            if (totalRemaining < 0)
            {
                return;
            }
            else if (totalRemaining == 0)
            {
                // add a copy of the list since they are reference type
                answer.Add(new List<int>(currentCombination));
            }
            else
            {
                for (int i = index; i < candidates.Length && totalRemaining >= candidates[i]; i++)
                {
                    if (i > index && candidates[i] == candidates[i - 1])
                    {
                        continue;
                    }

                    currentCombination.Add(candidates[i]);

                    Backtrack(answer, currentCombination, candidates, totalRemaining - candidates[i], i + 1);

                    // backs off all numbers from the list (recursively) so the array starts fresh on the next index
                    currentCombination.Remove(candidates[i]);
                }
            }
        }
    }
}
