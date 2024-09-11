/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        int index = 0;
        while(index < haystack.Length-needle.Length+1){
            int point = 0;
            while((needle[point] == haystack[point+index])){
                if(point < needle.Length-1){
                    point++;
                }else if(point == needle.Length-1){
                    return index;
                }
            }
            index++;
        }
        return -1;
    }
}
// @lc code=end

