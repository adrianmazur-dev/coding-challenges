# [🎯 9\. Palindrome Number](https://leetcode.com/problems/palindrome-number/)

## Problem Description
Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise.

A number is a palindrome when it reads the same forwards and backwards.

## Examples

### Example 1:
```
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
```

### Example 2:
```
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it reads 121-. Therefore it is not a palindrome.
```

### Example 3:
```
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
```

## Constraints:
- -2³¹ <= x <= 2³¹ - 1

## Function Signature
```csharp
public class Solution {
    public bool IsPalindrome(int x) {
        
    }
}
```

## Notes
- An integer is a palindrome when it reads the same backward as forward
- Negative numbers are not palindromes
- Numbers ending with 0 are only palindromes if the number is 0

## Example Test Cases
```csharp
// Test Case 1
x = 121
// Expected output: true

// Test Case 2
x = -121
// Expected output: false

// Test Case 3
x = 10
// Expected output: false

// Test Case 4
x = 0
// Expected output: true
```