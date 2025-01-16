using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2425.BitwiseXOROfAllPairings;

namespace TestProject
{
    public class BitwiseXOROfAllPairings
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.XorAllNums(new int[] { 2, 1, 3 }, new int[] { 10, 2, 5, 0 });
            int result2 = solution.XorAllNums(new int[] { 1, 2 }, new int[] { 3, 4 });

            Assert.Equal(13, result1);
            Assert.Equal(0, result2);

            result1 = solution.XorAllNums2(new int[] { 2, 1, 3 }, new int[] { 10, 2, 5, 0 });
            result2 = solution.XorAllNums2(new int[] { 1, 2 }, new int[] { 3, 4 });

            Assert.Equal(13, result1);
            Assert.Equal(0, result2);
        }
    }
}
