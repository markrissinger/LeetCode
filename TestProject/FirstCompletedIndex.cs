using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2661.FirstCompletellyPaintedRowOrColumn;

namespace TestProject
{
    public class FirstCompletedIndex
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.FirstCompleteIndex([1, 3, 4, 2], [[1, 4], [2, 3]]);
            int result2 = solution.FirstCompleteIndex([2, 8, 7, 4, 1, 3, 5, 6, 9], [[3, 2, 5], [1, 4, 6], [8, 7, 9]]);

            Assert.Equal(2, result1);
            Assert.Equal(3, result2);
        }
    }
}
