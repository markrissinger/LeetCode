using LeetCode._719.SmallestDistancePair;

namespace TestProject
{
    public class SmallestPairDistance

    {
        [Fact]
        public void Test()
        {
            int[] nums = { 1, 3, 1  };
            int target = 1;

            Solution solution = new();
            int smallestDistance = solution.SmallestDistancePair(nums, target);
            Assert.Equal(0, smallestDistance);
        }
    }
}