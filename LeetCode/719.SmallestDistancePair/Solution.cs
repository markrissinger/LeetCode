using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._719.SmallestDistancePair
{
    public class Solution
    {
        //public int SmallestDistancePair(int[] nums, int k)
        //{
        //    // sort ascending
        //    Array.Sort(nums);

        //    // sort into dictionary of distance, count
        //    Dictionary<int, int> distanceWithCount = [];

        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            int distance = nums[j] - nums[i];
        //            //distanceWithCount[distance] = distanceWithCount[distance] + 1;
        //            if (distanceWithCount.TryGetValue(distance, out int value))
        //            {
        //                distanceWithCount[distance]++;
        //            }
        //            else
        //            {
        //                distanceWithCount[distance] = 1;
        //            }
        //        }
        //    }

        //    // get an ordered array off the keys (alt to bringing in ordereddictionary)
        //    int[] distanceArray = [.. distanceWithCount.Keys];
        //    Array.Sort(distanceArray);

        //    int ii = 0;
        //    while (k > 0)
        //    {
        //        k -= distanceWithCount[distanceArray[ii]];
        //        ii++;
        //    }

        //    return distanceArray[ii - 1];
        //}


        //public int SmallestDistancePair(int[] nums, int k)
        //{
        //    // sort ascending
        //    Array.Sort(nums);

        //    // sort into dictionary of distance, count
        //    int[,] distanceWithCount = [nums,];

        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            int distance = nums[j] - nums[i];
        //            //distanceWithCount[distance] = distanceWithCount[distance] + 1;
        //            if (distanceWithCount.TryGetValue(distance, out int value))
        //            {
        //                distanceWithCount[distance]++;
        //            }
        //            else
        //            {
        //                distanceWithCount[distance] = 1;
        //            }
        //        }
        //    }

        //    // get an ordered array off the keys (alt to bringing in ordereddictionary)
        //    int[] distanceArray = [.. distanceWithCount.Keys];
        //    Array.Sort(distanceArray);

        //    int ii = 0;
        //    while (k > 0)
        //    {
        //        k -= distanceWithCount[distanceArray[ii]];
        //        ii++;
        //    }

        //    return distanceArray[ii - 1];
        //}
    }
}
