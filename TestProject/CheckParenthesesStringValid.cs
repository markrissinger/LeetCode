using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2116.CheckParenthesesStringValid;

namespace TestProject
{
    public class CheckParenthesesStringValid
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            bool result1 = solution.CanBeValid(")", "0");
            bool result2 = solution.CanBeValid("))()))", "010100");
            bool result3 = solution.CanBeValid("())()))()(()(((())(()()))))((((()())(())", "1011101100010001001011000000110010100101");
            bool result4 = solution.CanBeValid("())(()(()(())()())(())((())(()())((())))))(((((((())(()))))(", "100011110110011011010111100111011101111110000101001101001111");

            Assert.False(result1);
            Assert.True(result2);
            Assert.True(result3);
            Assert.False(result4);
        }
    }
}
