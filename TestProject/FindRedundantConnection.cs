using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._684.RedundantConnection;

namespace TestProject
{
    public class FindRedundantConnection
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[] result1 = solution.FindRedundantConnection([[1, 2], [1, 3], [2, 3]]);
            int[] result2 = solution.FindRedundantConnection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]);

            Assert.Equal([2, 3], result1);
            Assert.Equal([1, 4], result2);
        }
    }
}
