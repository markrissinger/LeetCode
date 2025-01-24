using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._802.FindEventualSafeStates
{
    public class Solution
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            int n = graph.Length;
            int[] indegree = new int[n];      // stores edges entering node x
            List<List<int>> adjacent = new(); // stores nodes coming from x
            for (int i = 0; i < n; i++)
            {
                adjacent.Add([]);
            }

            for (int i = 0; i < n; i++)
            {
                foreach(int node in graph[i])
                {
                    adjacent[node].Add(i);
                    indegree[i]++;
                }
            }

            Queue<int> queue = new(); // BFS leaf --> parent nodes
            for (int i = 0; i < n; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            bool[] safe = new bool[n]; // true if node is safe
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                safe[node] = true;

                foreach (int neighbor in adjacent[node])
                {
                    indegree[neighbor]--;
                    if (indegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            List<int> result = new();
            for (int i = 0; i < n; i++)
            {
                if (safe[i])
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
