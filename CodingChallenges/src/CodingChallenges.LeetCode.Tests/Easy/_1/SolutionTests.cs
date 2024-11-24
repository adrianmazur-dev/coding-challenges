using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solution = CodingChallenges.LeetCode.Easy._1.Solution;

namespace CodingChallenges.LeetCode.Tests.Easy._1
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 95, 4, -3 }, 92, new int[] { 2, 4 })]
        public void TwoSum_ReturnsCorrectIndices(int[] nums, int target, int[] expected)
        {
            // Act
            int[] result = Solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}