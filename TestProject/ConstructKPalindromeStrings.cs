using LeetCode._1400.ConstructKPalindromeStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ConstructKPalindromeStrings
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            Assert.True(solution.CanConstruct("annabelle", 2));
            Assert.False(solution.CanConstruct("leetcode", 3));
            Assert.True(solution.CanConstruct("true", 4));
        }
    }
}
