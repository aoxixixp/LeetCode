/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if(strs.Length == 0) return "";
        if(strs.Length == 1) return strs[0];
        Array.Sort(strs);
        for (int i = 0; i < strs[0].Length; i++){
            if(strs[0][i] != strs[strs.Length-1][i]){
                return strs[0].Substring(0, i);
            }
        }
        return strs[0];

        // int length = strs[0].Length;
        // int index = 0;
        // for (int i = 1; i < strs.Length; i++){
        //     if (strs[i].Length < length){
        //         length = strs[i].Length;
        //         index = i;
        //     }
        // }
        // string result = "";
        // for (int i = 1; i <= length; i++){
        //     long temp = strs[index].Substring(0, i).GetHashCode();
        //     for (int j = 0; j < strs.Length; j++){
        //         if(temp != strs[j].Substring(0, i).GetHashCode()){
        //             return result;
        //         }
        //     }
        //     result = strs[index].Substring(0,i);
        // }
        // return result;
    }
}
// @lc code=end

