using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.GreatestCommonDivisorOfStrings;

namespace TestProject.LeetCode75
{
    public class GreatestCommonDivisorOfStrings
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            string result1 = solution.GcdOfStrings("ABCABC", "ABC");
            string result2 = solution.GcdOfStrings("ABABAB", "ABAB");
            string result3 = solution.GcdOfStrings("LEET", "CODE");
            Assert.Equal("ABC", result1);
            Assert.Equal("AB", result2);
            Assert.Equal("", result3);
        }
    }
}
