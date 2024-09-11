/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        string num = x.ToString();
        if(x<0) return false;
        if(x==0)return true;
        char[] a = num.ToCharArray();
        Array.Reverse(a);
        if(num != new string(a))return false;
        return true;
    }
}
// @lc code=end

