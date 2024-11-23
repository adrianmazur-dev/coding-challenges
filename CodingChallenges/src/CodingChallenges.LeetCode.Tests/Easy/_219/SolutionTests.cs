using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

using CodingChallenges.LeetCode.Easy._219;

namespace CodingChallenges.LeetCode.Tests.Easy._219
{
    public class SolutionTests
    {
        [Fact]
        public void ContainsDuplicate_NoDuplicatesWithinRange_ReturnsFalse()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int k = 3;
            bool result = Solution.ContainsDuplicate(nums, k);
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_DuplicatesWithinRange_ReturnsTrue()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;
            bool result = Solution.ContainsDuplicate(nums, k);
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate_DuplicatesOutsideRange_ReturnsFalse()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 2;
            bool result = Solution.ContainsDuplicate(nums, k);
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_EmptyArray_ReturnsFalse()
        {
            int[] nums = { };
            int k = 1;
            bool result = Solution.ContainsDuplicate(nums, k);
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_SingleElementArray_ReturnsFalse()
        {
            int[] nums = { 1 };
            int k = 1;
            bool result = Solution.ContainsDuplicate(nums, k);
            Assert.False(result);
        }
    }
}