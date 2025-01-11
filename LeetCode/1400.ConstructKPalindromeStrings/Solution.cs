using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1400.ConstructKPalindromeStrings
{

//Example 1:
//Input: s = "annabelle", k = 2
//Output: true
//Explanation: You can construct two palindromes using all characters in s.
//Some possible constructions "anna" + "elble", "anbna" + "elle", "anellena" + "b"
//Example 2:
//Input: s = "leetcode", k = 3
//Output: false
//Explanation: It is impossible to construct 3 palindromes using all the characters of s.
//Example 3:
//Input: s = "true", k = 4
//Output: true
//Explanation: The only possible solution is to put each character in a separate string.

    public class Solution
    {
        public bool CanConstruct(string s, int k)
        {
            if (k > s.Length)
                return false;

            // get count of all letters in s
            int[] letterCounter = new int[26];
            foreach (char c in s)
            {
                int index = c - 'a';
                letterCounter[index]++;
            }

            // get count of all odd number of lettrs
            int oddLetterCounter = 0;
            foreach (var letterCount in letterCounter)
            {
                if (int.IsOddInteger(letterCount))
                    oddLetterCounter++;
            }

            
            if (oddLetterCounter > k)
                return false;

            // works because you can split each odd letter out to its own word,
            // and put all the even letter ones into the remaining word, also placing the last odd
            // one in the middle of that word if needed
            return true;
        }
    }
}
