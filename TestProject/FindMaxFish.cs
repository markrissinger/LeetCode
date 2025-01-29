using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2658.MaximumNumberOfFishInAGrid;

namespace TestProject
{
    public class FindMaxFish
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.FindMaxFish([[0, 2, 1, 0], [4, 0, 0, 3], [1, 0, 0, 4], [0, 3, 2, 0]]);
            int result2 = solution.FindMaxFish([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 1]]);

            Assert.Equal(7, result1);
            Assert.Equal(1, result2);
        }
    }
}
