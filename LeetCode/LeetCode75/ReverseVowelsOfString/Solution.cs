using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.ReverseVowelsOfString
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

            for (int i = 0, j = s.Length - 1; i < j;)
            {
                if (!vowels.Contains(s[i]))
                {
                    i++;
                    continue;
                }

                if (!vowels.Contains(s[j]))
                {
                    j--;
                    continue;
                }

                char temp = s[i];
                s = s.Remove(i, 1);
                s = s.Insert(i, s[j-1].ToString());
                s = s.Remove(j, 1);
                s = s.Insert(j, temp.ToString());
                i++;
                j--;
            }

            return s;
        }
    }
}
