using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1267.CountServersThatCommunicate
{
    public class Solution
    {
        public int CountServers(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            int[] rowCounts = new int[m];
            int[] colCounts = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        rowCounts[i]++;
                        colCounts[j]++;
                    }
                }
            }

            int result = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1 && 
                        (rowCounts[i] > 1 || colCounts[j] > 1))
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
