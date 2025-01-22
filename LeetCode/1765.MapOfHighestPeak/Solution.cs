using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1765.MapOfHighestPeak
{
    public class Solution
    {
        public int[][] HighestPeak(int[][] isWater)
        {
            // 0: land, 1: water
            int m = isWater.Length;
            int n = isWater[0].Length;

            int[] dx = { 0, 0, 1, -1 };
            int[] dy = { 1, -1, 0, 0 };

            int[][] result = new int[m][];
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = -1;
                }
            }

            Queue<(int, int)> cellQueue = new();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isWater[i][j] == 1)
                    {
                        result[i][j] = 0;
                        cellQueue.Enqueue((i, j));
                    }
                }
            }

            int heightOfNextLayer = 1;

            while (cellQueue.Count > 0)
            {
                int layerSize = cellQueue.Count;

                for (int i = 0; i < layerSize; i++)
                {
                    (int x, int y) = cellQueue.Dequeue();

                    for (int j = 0; j < 4; j++)
                    {
                        int neighborX = x + dx[j];
                        int neighborY = y + dy[j];

                        if (neighborX >= 0 && 
                            neighborX < m && 
                            neighborY >= 0 && 
                            neighborY < n && 
                            result[neighborX][neighborY] == -1)
                        {
                            result[neighborX][neighborY] = heightOfNextLayer;
                            cellQueue.Enqueue((neighborX, neighborY));
                        }
                    }
                }

                heightOfNextLayer++;
            }

            return result;
        }
    }
}
