using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.ReverseVowelsOfString;

namespace TestProject.LeetCode75
{
    public class ReverseVowelsOfString
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            string result1 = solution.ReverseVowels("IceCreAm");
            string result2 = solution.ReverseVowels("leetcode");
            Assert.Equal("AceCreIm", result1);
            Assert.Equal("leotcede", result2);
        }
    }
}
