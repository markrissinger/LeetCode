using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2017.GridGame;

namespace TestProject
{
    public class GridGame
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            long result1 = solution.GridGame([[2, 5, 4], [1, 5, 1]]);
            long result2 = solution.GridGame([[3, 3, 1], [8, 5, 2]]);
            long result3 = solution.GridGame([[1, 3, 1, 15], [1, 3, 3, 1]]);

            Assert.Equal(4, result1);
            Assert.Equal(4, result2);
            Assert.Equal(7, result3);
        }
    }
}
