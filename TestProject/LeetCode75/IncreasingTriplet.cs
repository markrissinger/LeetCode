using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.IncreasingTripletSubsequence;

namespace TestProject.LeetCode75
{
    public class IncreasingTriplet
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            bool result1 = solution.IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            bool result2 = solution.IncreasingTriplet(new int[] { 5, 4, 3, 2, 1 });
            bool result3 = solution.IncreasingTriplet(new int[] { 2, 1, 5, 0, 4, 6 });
            bool result4 = solution.IncreasingTriplet(new int[] { 20, 100, 10, 12, 5, 13 });

            Assert.True(result1);
            Assert.False(result2);
            Assert.True(result3);
            Assert.True(result4);
        }
    }
}
