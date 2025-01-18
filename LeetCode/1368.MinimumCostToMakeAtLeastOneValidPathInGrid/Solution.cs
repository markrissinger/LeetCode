using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1368.MinimumCostToMakeAtLeastOneValidPathInGrid
{
    public class Solution
    {
        public int MinCost(int[][] grid)
        {
            // 1: right, 2: left, 3: down, 4: up

            int numRows = grid.Length;
            int numColumns = grid[0].Length;

            int[][] minChanges = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                minChanges[i] = new int[numColumns];
                for (int j = 0; j < minChanges[i].Length; j++)
                {
                    minChanges[i][j] = int.MaxValue;
                }
            }
            minChanges[0][0] = 0;

            while (true)
            {
                // check for convergence
                int[][] previousState = new int[numRows][];
                for (int row = 0; row < numRows; row++)
                {
                    previousState[row] = new int[numColumns];
                    Array.Copy(minChanges[row], previousState[row], numColumns);
                }

                // forward pass
                for (int row = 0; row < numRows; row++)
                {
                    for (int col = 0; col < numColumns; col++)
                    {
                        // check above
                        if (row > 0)
                        {
                            int value = Math.Min(minChanges[row][col], minChanges[row - 1][col] + (grid[row - 1][col] == 3 ? 0 : 1));
                            minChanges[row][col] = value;
                        }

                        // check left
                        if (col > 0)
                        {
                            int value = Math.Min(minChanges[row][col], minChanges[row][col - 1] + (grid[row][col - 1] == 1 ? 0 : 1));
                            minChanges[row][col] = value;
                        }
                    }
                }

                // backward pass
                for (int row = numRows - 1; row >= 0; row--)
                {
                    for (int col = numColumns - 1; col >= 0; col--)
                    {
                        // check below
                        if (row < numRows - 1)
                        {
                            int value = Math.Min(minChanges[row][col], minChanges[row + 1][col] + (grid[row + 1][col] == 4 ? 0 : 1));
                            minChanges[row][col] = value;
                        }

                        // check right
                        if (col < numColumns - 1)
                        {
                            int value = Math.Min(minChanges[row][col], minChanges[row][col + 1] + (grid[row][col + 1] == 2 ? 0 : 1));
                            minChanges[row][col] = value;
                        }
                    }
                }

                bool matches = true;
                
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numColumns; j++)
                    {
                        if (minChanges[i][j] != previousState[i][j])
                        {
                            matches = false;
                            break;
                        }
                    }
                }

                if (matches)
                {
                    break;
                }
            }

            return minChanges[numRows - 1][numColumns - 1];
        }
    }
}