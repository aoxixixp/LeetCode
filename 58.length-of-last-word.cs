/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim(' ');
        int count = 0;
        for (int i = s.Length-1; i >= 0; i--) {
            if(s[i]!=' ')count++;
            else return count;
        }
        return count;
    }
}
// @lc code=end

