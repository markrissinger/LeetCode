using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.KidsWithGrestestNumberOfCandies;

namespace TestProject.LeetCode75
{
    public class KidsWithGrestestNumberOfCandies
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            IList<bool> result1 = solution.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
            IList<bool> result2 = solution.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
            IList<bool> result3 = solution.KidsWithCandies(new int[] { 12, 1, 12 }, 10);
            Assert.Equal(new List<bool> { true, true, true, false, true }, result1);
            Assert.Equal(new List<bool> { true, false, false, false, false }, result2);
            Assert.Equal(new List<bool> { true, false, true }, result3);
        }
    }
}
