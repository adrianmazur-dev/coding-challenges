using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenges.LeetCode.Easy._217
{
    public static class Solution
    {
        public static bool ContainsDuplicate(int[] nums) 
        {
            var hashset = new HashSet<int>();

            foreach (int num in nums)
            {
                if (!hashset.Add(num))
                    return true;
            }

            return false;
        }
    }
}