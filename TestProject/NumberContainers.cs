using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2349.DesignANumberContainerSystem;

namespace TestProject
{
    public class NumberContainers
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[] result1 = solution.Numb(["NumberContainers", "find", "change", "change", "change", "change", "find", "change", "find"],
                                                             [[], [10], [2, 10], [1, 10], [3, 10], [5, 10], [10], [1, 20], [10]]);
            int[] result2 = solution.FindRedundantConnection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]);

            Assert.Equal([null, -1, null, null, null, null, 1, null, 2], result1);
        }
    }
}
