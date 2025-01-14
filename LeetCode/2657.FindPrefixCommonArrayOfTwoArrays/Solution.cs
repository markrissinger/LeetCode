using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2657.FindPrefixCommonArrayOfTwoArrays
{
    public class Solution
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            int[] result = new int[A.Length];

            int[] lookup = new int[A.Length];

            int currCounter = 0;

            for(int i = 0; i < A.Length; i++)
            {
                int AIndex = A[i] - 1;
                int BIndex = B[i] - 1;
                lookup[AIndex]++;
                lookup[BIndex]++;

                if (AIndex == BIndex)
                {
                    currCounter++;
                }
                else
                {
                    if (lookup[AIndex] == 2)
                    {
                        currCounter++;
                    }
                    if (lookup[BIndex] == 2)
                    {
                        currCounter++;
                    }
                }                

                result[i] = currCounter;
            }

            return result;
        }
    }
}
