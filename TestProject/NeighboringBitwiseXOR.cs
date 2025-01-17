using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode._2683.NeighboringBitwiseXOR;

namespace TestProject
{
    public class NeighboringBitwiseXOR
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            bool result1 = solution.DoesValidArrayExist([1,1,0]);
            bool result2 = solution.DoesValidArrayExist([1, 1]);
            bool result3 = solution.DoesValidArrayExist([1, 0]);

            Assert.True(result1);
            Assert.True(result2);
            Assert.False(result3);

            result1 = solution.DoesValidArrayExist2([1, 1, 0]);
            result2 = solution.DoesValidArrayExist2([1, 1]);
            result3 = solution.DoesValidArrayExist2([1, 0]);

            Assert.True(result1);
            Assert.True(result2);
            Assert.False(result3);

            result1 = solution.DoesValidArrayExist3([1, 1, 0]);
            result2 = solution.DoesValidArrayExist3([1, 1]);
            result3 = solution.DoesValidArrayExist3([1, 0]);

            Assert.True(result1);
            Assert.True(result2);
            Assert.False(result3);
        }
    }
}
