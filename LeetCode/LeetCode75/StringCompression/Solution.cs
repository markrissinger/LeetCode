using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.StringCompression
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            string s = string.Empty;

            if (chars.Length == 1)
            {
                return 1;
            }
            
            int count = 1;

            for (int i = 1; i < chars.Length; i++)
            {            
                if (i == chars.Length - 1)
                {
                    if (chars[i] == chars[i - 1])
                    {
                        s += chars[i].ToString();
                        count++;
                        if (count > 1)
                        {
                            s += count.ToString();
                        }
                    }
                    else
                    {
                        s += chars[i - 1].ToString();
                        if (count > 1)
                        {
                            s += count.ToString();
                        }
                        s += chars[i].ToString();
                    }
                }
                else
                {
                    if (chars[i] == chars[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        s += chars[i - 1].ToString();
                        if (count > 1)
                        {
                            s += count.ToString();
                        }
                        count = 1;
                    }
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }

            return s.Length;
        }
    }
}
