/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length - 1]++;
        for(int i = digits.Length - 1; i >= 0; i--) {
            if(digits[i] == 10) {
                if(i == 0){
                    digits[0] = 0;
                }
                else{
                    digits[i] = 0;
                    digits[i-1]++;
                }
            }
        }
        if(digits[0] == 0)
        {
            int[] result = new int[digits.Length+1];
            result[0] = 1;
            Array.Copy(digits, 0, result, 1, digits.Length);
            return result;
        }
        return digits;
    }
}
// @lc code=end

