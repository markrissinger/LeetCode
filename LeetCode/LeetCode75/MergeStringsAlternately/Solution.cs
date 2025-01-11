using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new();

            int w1Length = word1.Length;
            int w2Length = word2.Length;

            int i1 = 0;
            int i2 = 0;

            while (i1 < w1Length || i2 < w2Length)
            {
                if (i1 < w1Length)
                {
                    result.Append(word1[i1]);
                }
                if (i2 < w2Length)
                {
                    result.Append(word2[i2]);
                }
                i1++;
                i2++;
            }

            return result.ToString();
        }
    }
}
