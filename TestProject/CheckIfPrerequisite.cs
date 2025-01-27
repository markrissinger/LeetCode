using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._1462.CourseScheduleIV;

namespace TestProject
{
    public class CheckIfPrerequisite
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            List<bool> result1 = solution.CheckIfPrerequisite(2, [[1, 0]], [[0, 1], [1, 0]]).ToList();
            List<bool> result2 = solution.CheckIfPrerequisite(2, [], [[1, 0], [0, 1]]).ToList();
            List<bool> result3 = solution.CheckIfPrerequisite(3, [[1, 2], [1, 0], [2, 0]], [[1, 0], [1, 2]]).ToList();

            Assert.Equal([false, true], result1);
            Assert.Equal([false, false], result2);
            Assert.Equal([true, true], result3);
        }
    }
}
