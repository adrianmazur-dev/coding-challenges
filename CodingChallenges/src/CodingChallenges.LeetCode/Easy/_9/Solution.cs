using System;

namespace CodingChallenges.LeetCode.Easy._9;

public static class Solution
{
    public static bool IsPalindrome(int x) 
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;
            
        int revertedNumber = 0;
        int original = x;
        
        while (x > 0) 
        {
            int lastDigit = x % 10;
            
            revertedNumber *= 10 + lastDigit;

            x /= 10;
        }
        
        return original == revertedNumber;
    }
}