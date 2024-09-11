/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length-1; i++){
            for (int j = i+1;j < nums.Length; j++){
                if (nums[i] + nums[j] == target){
                    int[] a = new int[2];
                    a[0] = i;
                    a[1] = j;
                    return a;
                }
            }
        }
        return null;
    }
}
// @lc code=end

