using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2948.MakeLexicographicallySmallestArrayBySwappingElements;

namespace TestProject
{
    public class LexicographicallySmallestArray
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[] result1 = solution.LexicographicallySmallestArray([1, 5, 3, 9, 8], 2);
            int[] result2 = solution.LexicographicallySmallestArray([1, 7, 6, 18, 2, 1], 3);
            int[] result3 = solution.LexicographicallySmallestArray([1, 7, 28, 19, 10], 3);
            int[] result4 = solution.LexicographicallySmallestArray([1000000000], 1);

            Assert.Equal([1, 3, 5, 8, 9], result1);
            Assert.Equal([1, 6, 7, 18, 1, 2], result2);
            Assert.Equal([1, 7, 28, 19, 10], result3);
            Assert.Equal([1000000000], result4);
        }
    }
}
