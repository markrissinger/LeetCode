using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._407.TrappingRainwaterII;

namespace TestProject
{
    public class TrappingRainWaterII
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.TrapRainWater([[1, 4, 3, 1, 3, 2], [3, 2, 1, 3, 2, 4], [2, 3, 3, 2, 3, 1]]);
            int result2 = solution.TrapRainWater([[3, 3, 3, 3, 3], [3, 2, 2, 2, 3], [3, 2, 1, 2, 3], [3, 2, 2, 2, 3], [3, 3, 3, 3, 3]]);

            Assert.Equal(4, result1);
            Assert.Equal(10, result2);
        }
    }
}
