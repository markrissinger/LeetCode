using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._3223.MinimumLengthStringAfterOperations
{
    public class Solution
    {
        public int MinimumLength(string s)
        {
            int[] letterCounter = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                letterCounter[index]++;
            }

            for (int i = 0; i < 26; i++)
            {
                int currValue = letterCounter[i];
                if (currValue < 2)
                {
                    continue;
                }

                if (int.IsEvenInteger(currValue)) 
                {
                    letterCounter[i] = 2;
                }
                else
                {
                    letterCounter[i] = 1;
                }
                //while (letterCounter[i] > 2)
                //{
                //    letterCounter[i] = (letterCounter[i] / 3) + (letterCounter[i] % 3);
                //}
            }

            return letterCounter.Sum();
        }
    }
}
