using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.ProductOfArrayExceptSelf;

namespace TestProject.LeetCode75
{
    public class ProductOfArrayExceptSelf
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            int[] result1 = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            int[] result2 = solution.ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
            Assert.Equal(new int[] { 24, 12, 8, 6 }, result1);
            Assert.Equal(new int[] { 0, 0, 9, 0, 0 }, result2);
        }
    }
}
