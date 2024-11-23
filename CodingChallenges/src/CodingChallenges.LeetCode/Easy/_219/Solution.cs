using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenges.LeetCode.Easy._219
{
    public static class Solution
    {
        public static bool ContainsDuplicate(int[] nums, int k) 
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                {
                    return true;
                }
                dict[nums[i]] = i;
            }

            return false;
        }
    }
}