using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode._684.RedundantConnection
{
    public class Solution
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            int n = edges.Length;

            List<List<int>> adjList = [];
            for (int i = 0; i < n; i++)
            {
                adjList.Add([]);
            }

            foreach (int[] edge in edges)
            {
                bool[] visited = new bool[n];

                if (IsConnected(edge[0] - 1, edge[1] - 1, visited, adjList))
                {
                    return [edge[0], edge[1]];
                }

                adjList[edge[0] - 1].Add(edge[1] - 1);
                adjList[edge[1] - 1].Add(edge[0] - 1);
            }

            return new int[] { };
        }

        private bool IsConnected(int src, int target, bool[] visited, List<List<int>> adjList
)
        {
            visited[src] = true;

            if (src == target)
            {
                return true;
            }

            bool isFound = false;
            foreach (int adj in adjList[src])
            {
                if (!visited[adj])
                {
                    isFound = isFound || IsConnected(adj, target, visited, adjList);
                }
            }

            return isFound;
        }
    }
}
