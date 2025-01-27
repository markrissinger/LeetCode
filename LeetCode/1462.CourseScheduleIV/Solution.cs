using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1462.CourseScheduleIV
{
    public class Solution
    {
        public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
        {
            Dictionary <int, List<int>> adjacentList = new();

            foreach (int[] prereq in prerequisites)
            {
                adjacentList.TryAdd(prereq[0], new());
                adjacentList[prereq[0]].Add(prereq[1]);
            }

            List<bool> result = new();
            for (int i = 0; i < queries.Length; i++)
            {
                result.Add(IsPrerequisite(adjacentList, new bool[numCourses], queries[i][0], queries[i][1]));
            }

            return result;
        }

        private bool IsPrerequisite(Dictionary<int, List<int>> adjacentList, bool[] visited, int source, int target)
        {
            visited[source] = true;

            if (source == target)
            {
                return true;
            }

            bool result = false;
            List<int> neighbors = adjacentList.ContainsKey(source) ? adjacentList[source] : new();
            foreach (int neighbor in neighbors)
            {
                if (!visited[neighbor])
                {
                    result = result || IsPrerequisite(adjacentList, visited, neighbor, target);
                }
            }

            return result;
        }
    }
}
