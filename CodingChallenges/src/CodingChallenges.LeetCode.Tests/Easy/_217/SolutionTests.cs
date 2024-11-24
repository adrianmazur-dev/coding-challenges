using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solution = CodingChallenges.LeetCode.Easy._217.Solution;

namespace CodingChallenges.LeetCode.Tests.Easy._217
{
    public class SolutionTests
    {
        [Fact]
        public void ContainsDuplicate_WhenArrayHasDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate_WhenArrayHasNoDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_WhenArrayIsEmpty_ReturnsFalse()
        {
            // Arrange
            int[] nums = Array.Empty<int>();

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicate_WhenArrayHasMultipleDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] { int.MinValue, 1, 2, int.MinValue })]
        [InlineData(new int[] { int.MaxValue, 1, 2, int.MaxValue })]
        public void ContainsDuplicate_WhenArrayHasExtremeBoundaryValues_ReturnsTrue(int[] nums)
        {
            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate_WhenArrayHasSingleElement_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1 };

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.False(result);
        }
    }
}