/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        int x = a.Length;
        int y = b.Length;
        bool carrybit = false;
        if(x > y) {
            for(int i = 0; i < x; i++) {
                if(i < y){
                    if((a[x-1-i]=='1'&& b[y-1-i]=='1'&& !carrybit) || (a[x-1-i]=='1'&& b[y-1-i]=='0'&& carrybit) || (a[x-1-i]=='0'&& b[y-1-i]=='1'&& carrybit)){
                        carrybit = true;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "0");
                    }else if(a[x-1-i]=='1'&& b[y-1-i]=='1'&& carrybit){
                        carrybit = true;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "1");
                    }else if((a[x-1-i]=='1'&& b[y-1-i]=='0'&& !carrybit)||(a[x-1-i]=='0'&& b[y-1-i]=='1'&& !carrybit)||(a[x-1-i]=='0'&& b[y-1-i]=='0'&& carrybit)){
                        carrybit = false;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "1");
                    }else{
                        carrybit = false;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "0");
                    }
                }else{
                    if(a[x-i-1]=='1'&&carrybit){
                        carrybit = true;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "0");
                    }else if((a[x-1-i] == '1' && !carrybit) || (a[x-1-i] == '0' && carrybit)){
                        carrybit = false;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "1");
                    }else{
                        carrybit = false;
                        a = a.Remove(x-1-i, 1);
                        a = a.Insert(x-1-i, "0");
                    }
                }
            }
            if(carrybit){
                return "1" + a;
            }
            else{
                return a;
            }
        }else{
            for(int i = 0; i < y; i++) {
                if(i < x){
                    if((a[x-1-i]=='1'&& b[y-1-i]=='1'&& !carrybit) || (a[x-1-i]=='1'&& b[y-1-i]=='0'&& carrybit) || (a[x-1-i]=='0'&& b[y-1-i]=='1'&& carrybit)){
                        carrybit = true;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "0");
                    }else if(a[x-1-i]=='1'&& b[y-1-i]=='1'&& carrybit){
                        carrybit = true;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "1");
                    }else if((a[x-1-i]=='1'&& b[y-1-i]=='0'&& !carrybit)||(a[x-1-i]=='0'&& b[y-1-i]=='1'&& !carrybit)||(a[x-1-i]=='0'&& b[y-1-i]=='0'&& carrybit)){
                        carrybit = false;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "1");
                    }else{
                        carrybit = false;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "0");
                    }
                }else{
                    if(b[y-i-1]=='1'&&carrybit){
                        carrybit = true;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "0");
                    }else if((b[y-1-i] == '1' && !carrybit) || (b[y-1-i] == '0' && carrybit)){
                        carrybit = false;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "1");
                    }else{
                        carrybit = false;
                        b = b.Remove(y-1-i, 1);
                        b = b.Insert(y-1-i, "0");
                    }
                }
            }
            if(carrybit){
                return "1" + b;
            }
            else{
                return b;
            }
        }
    }
}
// @lc code=end

