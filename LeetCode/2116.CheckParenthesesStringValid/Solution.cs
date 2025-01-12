using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2116.CheckParenthesesStringValid
{
    public class Solution
    {
        public bool CanBeValid(string s, string locked)
        {
            int sLength = s.Length;
            if (int.IsOddInteger(sLength))
            {
                return false;
            }

            Stack<int> openBrackets = new();
            Stack<int> unlocked = new();

            for (int i = 0; i < sLength; i++)
            {
                if (locked[i] == '0')
                {
                    unlocked.Push(i);
                }
                else if (s[i] == '(')
                {
                    openBrackets.Push(i);
                }
                else
                {
                    if (openBrackets.Count > 0)
                        openBrackets.Pop();
                    else if (unlocked.Count > 0)
                        unlocked.Pop();
                    else
                        return false;
                }
            }

            while (openBrackets.Count > 0 && unlocked.Count > 0 && openBrackets.Peek() < unlocked.Peek())
            {
                openBrackets.Pop();
                unlocked.Pop();
            }

            if (openBrackets.Count > 0)
                return false;

            return true;
        }

        //public bool CanBeValid(string s, string locked)
        //{
        //    int sLength = s.Length;
        //    if (int.IsOddInteger(sLength))
        //    {
        //        return false;
        //    }

        //    int balance = 0;
        //    int unlocked = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {

        //        if (locked[i] == '1')
        //        {
        //            if (s[i] == '(')
        //            {
        //                balance++;
        //            }
        //            if (s[i] == ')')
        //            {
        //                balance--;
        //            }
        //        }
        //        else
        //        {
        //            unlocked++;
        //        }

        //        if (balance < 0)
        //        {
        //            if (unlocked == 0)
        //            {
        //                return false;
        //            }
        //            balance++;
        //            unlocked--;
        //        }
        //    }

        //    if (balance - unlocked > 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}
