using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode75.StringCompression;

namespace TestProject.LeetCode75
{
    public class StringCompression
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();
            int result1 = solution.Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            int result2 = solution.Compress(new char[] { 'a' });
            int result3 = solution.Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
            int result4 = solution.Compress(new char[] { 'a', 'b', 'c' });
            Assert.Equal(6, result1);
            Assert.Equal(1, result2);
            Assert.Equal(4, result3);
            Assert.Equal(3, result4);
        }
    }
}
