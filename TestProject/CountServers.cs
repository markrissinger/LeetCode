using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._1267.CountServersThatCommunicate;

namespace TestProject
{
    public class CountServers
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.CountServers([[1, 0], [0, 1]]);
            int result2 = solution.CountServers([[1, 0], [1, 1]]);
            int result3 = solution.CountServers([[1, 1, 0, 0], [0, 0, 1, 0], [0, 0, 1, 0], [0, 0, 0, 1]]);

            Assert.Equal(0, result1);
            Assert.Equal(3, result2);
            Assert.Equal(4, result3);
        }
    }
}
