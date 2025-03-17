using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2206.DivideArrayIntoEqualPairs;

namespace TestProject
{
    public class DivideArrayIntoEqualPairs
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            bool result1 = solution.DivideArray(new int[] { 3, 2, 3, 2, 2, 2 });
            Assert.True(result1);

            bool result2 = solution.DivideArray(new int[] { 1, 2, 3, 4 });
            Assert.False(result2);
        }
    }
}
