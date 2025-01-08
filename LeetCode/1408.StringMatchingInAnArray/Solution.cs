using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StringMatchingInAnArray
{
    public class Solution
    {
        public IList<string> StringMatching(string[] words)
        {
            // return list
            List<string> substrings = new();

            // map of substrings by words
            //Dictionary<string, HashSet<string>> substringLookup = MapSubstrings(words);

            // order shortest to longest
            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            for (int i = 0; i < words.Length - 1; i++)
            {
                // current word
                string currentWord = words[i];

                for (int ii = i + 1; ii < words.Length; ii++)
                {
                    // bigger/longer words to compare against
                    string biggerWord = words[ii];

                    if (biggerWord.Contains(currentWord))
                    {
                        substrings.Add(currentWord);
                        break;
                    }

                    //// check in lookup to see if it's a substring
                    //if (substringLookup[biggerWord].Contains(currentWord))
                    //{
                    //    substrings.Add(currentWord);
                    //    break;
                    //}
                }
            }

            return substrings;
        }

        //// retrieve list of <word, substrings[]>
        //public Dictionary<string, HashSet<string>> MapSubstrings(string[] words)
        //{
        //    Dictionary<string, HashSet<string>> mappedSubstrings = new();
        //
        //    foreach (string word in words)
        //    {
        //        // substring combos for the current word
        //        HashSet<string> substrings = new();
        //
        //
        //        List<string> substringsToPrefix = new();
        //
        //        for (int i = word.Length - 1; i >= 0; i--)
        //        {
        //            // new substring combos from the next character in the sequence
        //            HashSet<string> newSubstringsToUnion = new();
        //
        //            string currentCharacter = word[i].ToString();
        //            newSubstringsToUnion.Add(currentCharacter);
        //
        //            // add new combos based off the existing
        //            foreach (string existingSubstring in substringsToPrefix)
        //            {
        //                string newSubstring = currentCharacter + existingSubstring;
        //
        //                newSubstringsToUnion.Add(newSubstring);
        //            }
        //
        //            // union the hashsets to combine the new combos for this character with the existing
        //            substrings.UnionWith(newSubstringsToUnion);
        //            substringsToPrefix = newSubstringsToUnion.ToList();
        //        }
        //
        //        mappedSubstrings.Add(word, substrings);
        //    }
        //
        //    return mappedSubstrings;
        //}
    }
}
