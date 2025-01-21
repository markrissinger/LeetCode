using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2017.GridGame
{
    public class Solution
    {
        public long GridGame(int[][] grid)
        {
            int n = grid[0].Length;

            long firstRowSum = 0;
            for (int num = 0; num < n; num++)
            {
                firstRowSum += grid[0][num];
            }

            long secondRowSum = 0;
            long minimumSum = long.MaxValue;
            for (int num = 0; num < n; ++num)
            {
                firstRowSum -= grid[0][num];

                minimumSum = Math.Min(minimumSum, Math.Max(firstRowSum, secondRowSum));

                secondRowSum += grid[1][num];
            }

            return minimumSum;
        }
    }
}
