using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2683.NeighboringBitwiseXOR
{
    public class Solution
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            int arrayLength = derived.Length;

            int[] original = new int[arrayLength + 1];

            // 0 starter
            original[0] = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                original[i + 1] = derived[i] ^ original[i];
            }

            bool check0 = (original[0] == original[original.Length - 1]);
            if (check0)
                return true;

            // 1 starter
            original[0] = 1;
            for (int i = 0; i < arrayLength; i++)
            {
                original[i + 1] = derived[i] ^ original[i];
            }

            bool check1 = (original[0] == original[original.Length - 1]);
            if (check1)
                return true;

            return false;
        }


        public bool DoesValidArrayExist2(int[] derived)
        {
            int XOR = 0;

            // elements up until the last
            for (int i = 0; i < derived.Length; i++)
            {
                XOR = XOR ^ derived[i];
            }

            return XOR == 0;
        }


        public bool DoesValidArrayExist3(int[] derived)
        {
            int sum = 0;

            for (int i = 0; i < derived.Length; i++)
            {
                sum += derived[i];
            }

            return sum % 2 == 0;
        }
    }
}
