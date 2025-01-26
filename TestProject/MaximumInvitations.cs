using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2127.MaximumEmployeesToBeInvitedToAMeeting;

namespace TestProject
{
    public class MaximumInvitations
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.MaximumInvitations2([2, 2, 1, 2]);
            int result2 = solution.MaximumInvitations2([1, 2, 0]);
            int result3 = solution.MaximumInvitations2([3, 0, 1, 4, 1]);

            Assert.Equal(3, result1);
            Assert.Equal(3, result2);
            Assert.Equal(4, result3);
        }
    }
}
