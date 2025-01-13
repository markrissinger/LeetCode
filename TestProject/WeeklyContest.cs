using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.WeeklyContest;

namespace TestProject
{
    public class WeeklyContest
    {
        [Fact]
        public void Test()
        {
            Solution solution = new();

            int[] list1 = new int[2] { 1, 2 };
            int[] list2 = new int[2] { 3, 4 };
            int[][] lists = new int[][] { list1, list2 };
            List<int> result1 = solution.ZigzagTraversal(new int[][] { new int[2]{ 1, 2 }, new int[2] { 3, 4 } }).ToList();
            List<int> result2 = solution.ZigzagTraversal(new int[][] { new int[2] { 2, 1 }, new int[2] { 2, 1 }, new int[2] { 2, 1 } }).ToList();
            List<int> result3 = solution.ZigzagTraversal(new int[][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } }).ToList();

            Assert.Equal(new List<int>(){ 1, 4 },  result1);
            Assert.Equal(new List<int>() { 2, 1, 2 }, result2);
            Assert.Equal(new List<int>() { 1, 3, 5, 7, 9 }, result3);
        }
    }
}
