using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2657.FindPrefixCommonArrayOfTwoArrays;

namespace TestProject
{
    public class FindThePrefixCommonArray
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[] result1 = solution.FindThePrefixCommonArray(new int[] { 1, 3, 2, 4 }, new int[] { 3, 1, 2, 4 });
            int[] result2 = solution.FindThePrefixCommonArray(new int[] { 2, 3, 1 }, new int[] { 3, 1, 2 });
            Assert.Equal(new int[] { 0, 2, 3, 4 }, result1);
            Assert.Equal(new int[] { 0, 1, 3 }, result2);
        }
    }
}
