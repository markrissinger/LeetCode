using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._3223.MinimumLengthStringAfterOperations;

namespace TestProject
{
    public class MinimumLength
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.MinimumLength("abaacbcbb");
            int result2 = solution.MinimumLength("aa");

            Assert.Equal( 5, result1);
            Assert.Equal(2, result2);
        }
    }
}
