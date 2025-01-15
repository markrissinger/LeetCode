using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.ReverseWordsInString
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            int originalLength = s.Length;

            List<string> words = [];
            string currentWord = string.Empty;

            for (int i = 0; i < originalLength; i++)
            {
                if (s[i] == ' ')
                {
                    if (currentWord != string.Empty)
                    {
                        // reached end of a word
                        words.Add(currentWord);
                        currentWord = string.Empty;
                    }
                }
                else
                {
                    currentWord += s[i];

                    if (i == originalLength - 1)
                    {
                        // reached end of a word
                        words.Add(currentWord);
                        currentWord = string.Empty;
                    }
                }
            }

            s = string.Empty;

            for (int i = words.Count() - 1; i >= 0; i--)
            {
                s += words[i];
                if (i != 0)
                {
                    s += " ";
                }
            }

            return s;
        }
    }
}
