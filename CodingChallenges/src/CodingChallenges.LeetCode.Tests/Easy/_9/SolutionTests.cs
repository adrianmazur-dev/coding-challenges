using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solution = CodingChallenges.LeetCode.Easy._9.Solution;

namespace CodingChallenges.LeetCode.Tests.Easy._9
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(123, false)]
        public void IsPalindrome(int x, bool expected)
        {
            // Act
            bool result = Solution.IsPalindrome(x);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}