using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._1765.MapOfHighestPeak;

namespace TestProject
{
    public class HighestPeak
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[][] result1 = solution.HighestPeak([[0, 1], [0, 0]]);
            int[][] result2 = solution.HighestPeak([[0, 0, 1], [1, 0, 0], [0, 0, 0]]);

            Assert.Equal([[1, 0], [2, 1]], result1);
            Assert.Equal([[1, 1, 0], [0, 1, 1], [1, 2, 2]], result2);
        }
    }
}
