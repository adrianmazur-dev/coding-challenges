using System;

namespace CodingChallenges.LeetCode.Easy._1;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int index=0; index < nums.Length; index++)
        {
            int complement = target - nums[index];

            if (map.TryGetValue(complement, out int complementIndex))
                return [complementIndex, index];

            if (!map.ContainsKey(nums[index]))
                map.Add(nums[index], index);
        }

        return [];
    }
}