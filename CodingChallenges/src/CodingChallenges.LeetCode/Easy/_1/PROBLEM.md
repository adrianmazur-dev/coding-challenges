# [🎯 1\. Two Sum](https://leetcode.com/problems/two-sum)

## Problem Description

Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

## Examples

### Example 1:
```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
```

### Example 2:
```
Input: nums = [3,2,4], target = 6
Output: [1,2]
Explanation: Because nums[1] + nums[2] == 6, we return [1, 2].
```

### Example 3:
```
Input: nums = [3,3], target = 6
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 6, we return [0, 1].
```

## Constraints:
- `2 <= nums.length <= 104`
- `-109 <= nums[i] <= 109`
- `-109 <= target <= 109`
- Only one valid answer exists.

## Follow-up
Can you come up with an algorithm that is less than O(n²) time complexity?

## Function Signature
```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
    }
}
```

## Notes
- The solution must return indices, not the actual numbers
- The same element cannot be used twice
- There is exactly one solution
- The order of returned indices doesn't matter

## Example Test Cases
```csharp
// Test Case 1
nums = [2,7,11,15]
target = 9
// Expected output: [0,1]

// Test Case 2
nums = [3,2,4]
target = 6
// Expected output: [1,2]

// Test Case 3
nums = [3,3]
target = 6
// Expected output: [0,1]
```