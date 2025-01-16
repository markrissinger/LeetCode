using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2425.BitwiseXOROfAllPairings
{
    public class Solution
    {
        public int XorAllNums(int[] nums1, int[] nums2)
        {
            int num1Length = nums1.Length;
            int num2Length = nums2.Length;

            Dictionary<int, int> frequency = [];

            for (int i = 0; i < num1Length; i++)
            {
                int currentNum = nums1[i];
                frequency.TryGetValue(currentNum, out var currentCount);
                frequency[currentNum] = currentCount + num2Length;
            }

            for (int i = 0; i < num2Length; i++)
            {
                int currentNum = nums2[i];
                frequency.TryGetValue(currentNum, out var currentCount);
                frequency[currentNum] = currentCount + num1Length;
            }

            int result = 0;
            foreach (var (key, value) in frequency)
            {
                if (value % 2 == 1)
                {
                    result ^= key;
                }
            }

            return result;
        }


        public int XorAllNums2(int[] nums1, int[] nums2)
        {
            int xor1 = 0;
            int xor2 = 0;

            int num1Length = nums1.Length;
            int num2Length = nums2.Length;

            if (num2Length % 2 != 0)
            {
                for (int i = 0; i < num1Length; i++)
                {
                    xor1 ^= nums1[i];
                }
            }

            if (num1Length % 2 != 0)
            {
                for (int i = 0; i < num2Length; i++)
                {
                    xor2 ^= nums2[i];
                }
            }

            return xor1 ^ xor2;
        }
    }
}
