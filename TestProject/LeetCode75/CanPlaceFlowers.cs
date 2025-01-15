using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.CanPlaceFlowers;

namespace TestProject.LeetCode75
{
    public class CanPlaceFlowers
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            bool result1 = solution.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
            bool result2 = solution.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);
            Assert.True(result1);
            Assert.False(result2);
        }
    }
}
