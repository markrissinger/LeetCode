using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._802.FindEventualSafeStates;

namespace TestProject
{
    public class EventualSafeNodes
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            List<int> result1 = solution.EventualSafeNodes([[1, 2], [2, 3], [5], [0], [5], [], []]).ToList();
            List<int> result2 = solution.EventualSafeNodes([[1, 2, 3, 4], [1, 2], [3, 4], [0, 4], []]).ToList();

            Assert.Equal([2, 4, 5, 6], result1);
            Assert.Equal([4], result2);
        }
    }
}
