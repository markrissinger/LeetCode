using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode._2127.MaximumEmployeesToBeInvitedToAMeeting
{
    public class Solution
    {
        public int MaximumInvitations(int[] favorite)
        {
            int n = favorite.Length;
            int[] inDegree = new int[n];

            // calculate indegree for each employee (count of employees who favorite each person)
            for (int i = 0; i < n; ++i)
            {
                inDegree[favorite[i]]++;
            }

            // topological sorting to remove noncyclic edges (get those who were not favorite of anyone)
            Queue<int> queue = new();
            for (int i = 0; i < n; ++i)
            {
                if (inDegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            int[] depth = new int[n];
            Array.Fill(depth, 1);

            while (queue.Any())
            {
                int currentNode = queue.Dequeue();
                int nextNode = favorite[currentNode];

                // if the next person is favorited by the current person, update the depth
                depth[nextNode] = Math.Max(depth[nextNode], depth[currentNode] + 1);
                
                // when person is no longer favorited by anyone, remove it from the queue
                if (--inDegree[nextNode] == 0)
                {
                    queue.Enqueue(nextNode);
                }
            }

            int longestCycle = 0;
            int twoCycleInvitations = 0;

            // find the longest cycle and count the number of 2-cycle invitations
            for (int i = 0; i < n; ++i)
            {                
                if (inDegree[i] == 0) continue; // already processed

                int cycleLength = 0;
                int current = i;
                while (inDegree[current] != 0)
                {
                    inDegree[current] = 0;
                    cycleLength++;
                    current = favorite[current];
                }

                if (cycleLength == 2)
                {
                    // 2-cycle invitation; add the depth of the two persons
                    twoCycleInvitations += depth[i] + depth[favorite[i]];
                }
                else
                {
                    longestCycle = Math.Max(longestCycle, twoCycleInvitations);
                }
            }

            return Math.Max(longestCycle, twoCycleInvitations);
        }


        public int MaximumInvitations2(int[] favorite)
        {
            int n = favorite.Length;
            int[] inDegree = new int[n];

            // Calculate in-degree for each node
            for (int person = 0; person < n; ++person)
            {
                inDegree[favorite[person]]++;
            }

            // Topological sorting to remove non-cycle nodes
            Queue<int> q = new();
            for (int person = 0; person < n; ++person)
            {
                if (inDegree[person] == 0)
                {
                    q.Enqueue(person);
                }
            }

            int[] depth = new int[n]; // Depth of each node
            Array.Fill(depth, 1);

            while (q.Any())
            {
                int currentNode = q.Dequeue();
                int nextNode = favorite[currentNode];
                depth[nextNode] = Math.Max(depth[nextNode], depth[currentNode] + 1);
                if (--inDegree[nextNode] == 0)
                {
                    q.Enqueue(nextNode);
                }
            }

            int longestCycle = 0;
            int twoCycleInvitations = 0;

            // Detect cycles
            for (int person = 0; person < n; ++person)
            {
                if (inDegree[person] == 0) continue; // Already processed

                int cycleLength = 0;
                int current = person;
                while (inDegree[current] != 0)
                {
                    inDegree[current] = 0; // Mark as visited
                    cycleLength++;
                    current = favorite[current];
                }

                if (cycleLength == 2)
                {
                    // For 2-cycles, add the depth of both nodes
                    twoCycleInvitations += depth[person] + depth[favorite[person]];
                }
                else
                {
                    longestCycle = Math.Max(longestCycle, cycleLength);
                }
            }

            return Math.Max(longestCycle, twoCycleInvitations);
        }
    }
}
