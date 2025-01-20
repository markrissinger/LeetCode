using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2661.FirstCompletellyPaintedRowOrColumn
{
    public class Solution
    {
        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            int[,] mat2d = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat2d[i, j] = mat[i][j];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {

                bool matchingCellPainted = false;
                int paintedRow = 0;
                int paintedCol = 0;
                for (int r = 0; r < m; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (arr[i] == mat2d[r, c])
                        {
                            paintedRow = r;
                            paintedCol = c;
                            mat2d[r, c] = 0;
                            matchingCellPainted = true;
                            break;
                        }
                    }

                    if (matchingCellPainted)
                        break;
                }

                for (int r = 0; r < m; r++)
                {
                    if (mat2d[r, paintedCol] != 0)
                    {
                        break;
                    }
                    if (r == m - 1)
                    {
                        return i;
                    }
                }
                for (int c = 0; c < n; c++)
                {
                    if (mat2d[paintedRow, c] != 0)
                    {
                        break;
                    }
                    if (c == n - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        //public int FirstCompleteIndex(int[] arr, int[][] mat)
        //{
        //    int numRows = mat.Length;
        //    int numCols = mat[0].Length;

        //    Dictionary<int, KeyValuePair<int, int>> numToPos = [];

        //    // Populate the numToPos map by iterating over the matrix
        //    for (int row = 0; row < numRows; row++)
        //    {
        //        for (int col = 0; col < numCols; col++)
        //        {
        //            int value = mat[row][col];
        //            numToPos[value] = new KeyValuePair<int, int>(row, col);
        //        }
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int num = arr[i];
        //        KeyValuePair<int, int> pos = numToPos[num];
        //        int row = pos.Key;
        //        int col = pos.Value;
        //        mat[row][col] = -mat[row][col]; // mark as seen

        //        // Check if the row or column is completely painted
        //        if (checkRow(row, mat) || checkColumn(col, mat))
        //        {
        //            return i;
        //        }
        //    }

        //    return -1; // This line will never be reached as per the problem statement
        //}

        //private bool checkRow(int row, int[][] mat)
        //{
        //    // Return true if row is completely seen
        //    for (int col = 0; col < mat[0].Length; col++)
        //    {
        //        if (mat[row][col] > 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //private bool checkColumn(int col, int[][] mat)
        //{
        //    // Return true if col is completely seen
        //    for (int row = 0; row < mat.Length; row++)
        //    {
        //        if (mat[row][col] > 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
