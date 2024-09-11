/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        Stack<char> s2 = new Stack<char>();
        s2.Push(s[0]);
        for(int i = 1; i < s.Length; i++){
            switch(s[i]){
                case ')':
                    if(s2.Count == 0 || s2.Peek() != '(')return false;
                    else
                        s2.Pop();
                    break;
                case '}':
                    if(s2.Count == 0 || s2.Peek() != '{')return false;
                    else
                        s2.Pop();
                    break;
                case ']':
                    if(s2.Count == 0 || s2.Peek() != '[')return false;
                    else
                        s2.Pop();
                    break;
                default:
                    s2.Push(s[i]);
                    break;
            }
        }
        return (s2.Count == 0) ? true : false;
    }
}
// @lc code=end

