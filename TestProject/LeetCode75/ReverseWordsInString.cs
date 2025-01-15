using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.ReverseWordsInString;

namespace TestProject.LeetCode75
{
    public class ReverseWordsInString
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            string result1 = solution.ReverseWords("the sky is blue");
            string result2 = solution.ReverseWords("  hello world  ");
            string result3 = solution.ReverseWords("a good   example");
            string result4 = solution.ReverseWords("t ");
            Assert.Equal("blue is sky the", result1);
            Assert.Equal("world hello", result2);
            Assert.Equal("example good a", result3);
            Assert.Equal("t", result4);
        }
    }
}
