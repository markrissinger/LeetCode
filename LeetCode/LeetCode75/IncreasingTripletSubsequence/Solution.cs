using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.IncreasingTripletSubsequence
{
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            bool result = false;

            if (nums.Length < 3)
            {
                return result;
            }

            int lowestNum = nums[0];

            Dictionary<int, List<int>> potentialTriplets = new(){ { lowestNum, new List<int>() } };

            for(int i = 1; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (currentNum < lowestNum)
                {
                    lowestNum = currentNum;
                    potentialTriplets.Add(lowestNum, new List<int> { });
                }
                else
                {
                    bool foundTriplet = false;
                    foreach (var triplet in potentialTriplets)
                    {
                        if (triplet.Key < currentNum)
                        {
                            if (triplet.Value.Count == 0)
                            {
                                triplet.Value.Add(currentNum);
                            }
                            else
                            {
                                if (triplet.Value[0] < currentNum)
                                {
                                    triplet.Value.Add(currentNum);
                                }
                                else
                                {
                                    triplet.Value[0] = currentNum;
                                }
                            }

                            if (triplet.Value.Count == 2)
                            {
                                foundTriplet = true;
                                break;
                            }
                        }
                    }
                    if (foundTriplet)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
