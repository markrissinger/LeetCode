using LeetCode.StringMatchingInAnArray;

namespace TestProject
{
    public class StringMatchingInAnArray
    {
        [Fact]
        public void Test1()
        {
            string[] testWords = { "leetcoder", "leetcode", "od", "hamlet", "am" };

            Solution solution = new();
            IList<string> matchingWords = solution.StringMatching(testWords);
            List<string> output = matchingWords.ToList();
            Assert.True(output.Count() == 3);
        }
    }
}