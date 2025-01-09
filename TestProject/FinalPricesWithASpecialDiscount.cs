using LeetCode._1475.FinalPricesWithASpecialDiscountInAShop;

namespace TestProject
{
    public class FinalPricesWithASpecialDiscount

    {
        [Fact]
        public void Test()
        {
            int[] nums = { 8, 4, 6, 2, 3 };

            Solution solution = new();
            int[] salePrices = solution.FinalPrices(nums);
            Assert.Equal(4, salePrices[0]);
        }
    }
}