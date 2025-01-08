using LeetCode.CombinationSumII;

namespace TestProject
{
    public class CombinationSumII
    {
        [Fact]
        public void Test()
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5  };
            int target = 8;

            Solution solution = new();
            IList<IList<int>> combinations = solution.CombinationSum2(candidates, target);
            IList<IList<int>> combinationsCheck = new List<IList<int>>() { new List<int>() { 1, 1, 6 }, new List<int>() { 1, 2, 5 }, new List<int>() { 1, 7 }, new List<int>() { 2, 6 }, };
            Assert.Equal(combinationsCheck, combinations);
        }
    }
}