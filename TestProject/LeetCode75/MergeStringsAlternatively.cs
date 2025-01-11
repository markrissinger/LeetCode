using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.MergeStringsAlternately;

namespace TestProject.LeetCode75
{
    public class MergeStringsAlternatively
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            string result1 = solution.MergeAlternately("abc", "pqr");
            string result2 = solution.MergeAlternately("ab", "pqrs");
            string result3 = solution.MergeAlternately("abcd", "pq");
            Assert.Equal("apbqcr", result1);
            Assert.Equal("apbqrs", result2);
            Assert.Equal("apbqcd", result3);
        }
    }
}
