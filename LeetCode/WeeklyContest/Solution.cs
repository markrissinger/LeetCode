using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WeeklyContest
{
    public class Solution
    {
        public IList<int> ZigzagTraversal(int[][] grid)
        {
            IList<int> ints = new List<int>();

            int columnCount = grid[0].Length;
            bool oddNumberOfColumns = int.IsOddInteger(columnCount);

            bool leftToRightEven = true;

            // loop over row
            for (int i = 0; i < grid.Length; i++)
            {

                // loop over columns in row
                for (int j = 0; j < grid[i].Length; j++)
                {
                    bool columnIsEven = int.IsEvenInteger(j);

                    if (leftToRightEven && columnIsEven)
                        ints.Add(grid[i][j]);
                    else if (!leftToRightEven && !columnIsEven)
                        if (oddNumberOfColumns)
                            ints.Add(grid[i][columnCount - 1 - j]);
                        else
                            ints.Add(grid[i][columnCount - j]);
                }

                leftToRightEven = !leftToRightEven;
            }

            return ints;
        }

        public int MaximumAmount(int[][] coins)
        {
            int currentCoins = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 0;j < coins[i].Length; j++)
                {

                }
            }

            return currentCoins;
        }

        public int MinMaxWeight(int n, int[][] edges, int threshold)
        {
            return 0;
        }
    }
}
