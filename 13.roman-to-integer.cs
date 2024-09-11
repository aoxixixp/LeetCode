/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        int num = 0;
        for (int i = 0; i < s.Length-1; i++) {
            if(RomanToRoman[s.Substring(i, 1)] >= RomanToRoman[s.Substring(i+1, 1)]) {
                num += RomanToRoman[s.Substring(i, 1)];
            }else{
                num -= RomanToRoman[s.Substring(i, 1)];
            }
        }
        return num+RomanToRoman[s.Substring(s.Length-1, 1)];
    }

    public static Dictionary<string, int> RomanToRoman = new Dictionary<string, int>() {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000}
    };
}
// @lc code=end

