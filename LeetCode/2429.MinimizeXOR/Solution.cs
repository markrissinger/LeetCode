using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2429.MinimizeXOR
{
    public class Solution
    {
        public int MinimizeXor(int num1, int num2)
        {
            int result = num1;

            int targetSetBitsCount = int.PopCount(num2);
            int setBitsCount = int.PopCount(num1);

            int currentBit = 0;

            while(setBitsCount < targetSetBitsCount)
            {
                if (!isSet(result, currentBit))
                {
                    result = setBit(result, currentBit);
                    setBitsCount++;
                }
                currentBit++;
            }

            while (setBitsCount > targetSetBitsCount)
            {
                if (isSet(result, currentBit))
                {
                    result = unsetBit(result, currentBit);
                    setBitsCount--;
                }
                currentBit++;
            }

            return result;
        }

        public int MinimizeXor2(int num1, int num2)
        {
            int result = 0;

            int targetSetBitsCount = int.PopCount(num2);
            int setBitsCount = 0;
            int currentBit = 31;

            while (setBitsCount < targetSetBitsCount)
            {
                if (isSet(num1, currentBit) || (targetSetBitsCount - setBitsCount > currentBit))
                {
                    result = setBit(result, currentBit);
                    setBitsCount++;
                }
                currentBit--;
            }

            return result;
        }

        // Helper function to check if the given bit position in result is set (1).
        private bool isSet(int x, int bit)
        {
            return (x & (1 << bit)) != 0;
        }

        // Helper function to set the given bit position in result to 1.
        private int setBit(int x, int bit)
        {
            return x | (1 << bit);
        }

        // Helper function to unset the given bit position in x (set it to 0).
        private int unsetBit(int x, int bit)
        {
            return x & ~(1 << bit);
        }
    }
}
