using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._1368.MinimumCostToMakeAtLeastOneValidPathInGrid;

namespace TestProject
{
    public class MinimumCostToMakeAtLeastOneValidPathInGrid
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.MinCost([[1, 1, 1, 1], [2, 2, 2, 2], [1, 1, 1, 1], [2, 2, 2, 2]]);
            int result2 = solution.MinCost([[1, 1, 3], [3, 2, 2], [1, 1, 4]]);
            int result3 = solution.MinCost([[1, 2], [4, 3]]);

            Assert.Equal(3, result1);
            Assert.Equal(0, result2);
            Assert.Equal(1, result3);
        }
    }
}
