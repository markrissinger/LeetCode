using LeetCode._916.WordSubsets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{

    public class WordSubsets
    {
        [Fact]
        public void Test1()
        {
            string[] words1 = { "amazon", "apple", "facebook", "google", "leetcode" };
            string[] words2 = { "e", "o" };

            Solution solution = new();
            IList<string> matchingWords = solution.WordSubsets(words1, words2);
            IList<string> output = new List<string>() { "facebook", "google", "leetcode" };
            Assert.Equal(output, matchingWords);
        }
    }
}
