/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = 0;
        int temp = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > temp) {
                nums[++length] = nums[i];
                temp = nums[i];
            }
        }
        return length+1;
    }
}
// @lc code=end

