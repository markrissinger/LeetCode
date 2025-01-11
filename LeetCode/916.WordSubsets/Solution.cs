using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._916.WordSubsets
{
    public class Solution
    {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            Array.Sort(words2);

            List<string> result = new List<string>();

            //setup lookups
            IList<int[]> words1Lookup = ListOfLettersPerWord(words1);
            int[] maxFreqLettersPerWords = MaxFreqLettersPerWords(words2);

            // loop over main set of words
            for (int i = 0; i < words1Lookup.Count; i++)
            {
                int[] word1 = words1Lookup[i];

                bool matchesAll = true;

                // compare each letter count
                for (int ii = 0; ii < 26; ii++)
                {
                    if (word1[ii] < maxFreqLettersPerWords[ii])
                    { 
                        // word had less instances of char than the max freq
                        matchesAll = false; 
                        break;
                    }
                }

                if (matchesAll)
                {
                    result.Add(words1[i]);
                }
            }

            return result;
        }

        public IList<int[]> ListOfLettersPerWord(string[] words1)
        {
            List<int[]> result = new();

            // loop over each word
            foreach (var word in words1)
            {
                int[] lettersForWord = new int[26];

                // loop over each letter
                foreach(var character in word)
                {
                    // determine index of letter and increment
                    int index = character - 'a';
                    lettersForWord[index]++;
                }

                result.Add(lettersForWord);
            }

            return result;
        }

        public int[] MaxFreqLettersPerWords(string[] words2)
        {
            int[] result = new int[26];

            // loop over each word
            foreach (var word in words2)
            {
                int[] lettersForWord = new int[26];

                // loop over each letter
                foreach (var character in word)
                {
                    // determine index of letter and increment
                    int index = character - 'a';
                    lettersForWord[index]++;
                }

                for(int i = 0; i < 26; i++)
                {
                    if (lettersForWord[i] > result[i])
                        result[i] = lettersForWord[i];
                }
            }

            return result;
        }
    }
}
