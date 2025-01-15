using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2429.MinimizeXOR;

namespace TestProject
{
    public class MinimizeXOR
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int result1 = solution.MinimizeXor(3, 5);
            int result2 = solution.MinimizeXor(1, 12);

            Assert.Equal(3, result1);
            Assert.Equal(3, result2);


            result1 = solution.MinimizeXor2(3, 5);
            result2 = solution.MinimizeXor2(1, 12);

            Assert.Equal(3, result1);
            Assert.Equal(3, result2);
        }
    }
}
