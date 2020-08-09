/*
 * @lc app=leetcode.cn id=387 lang=csharp
 *
 * [387] 字符串中的第一个唯一字符
 */

// @lc code=start
public class Solution {
    public int FirstUniqChar(string s) {
        int[] indexs = new int[26];
        for(int i = 0;i<s.Length;i++)
        {
            indexs[s[i]-'a']++;
        }
        
        int length = s.Length ;
        for(int i = 0;i < length;i++)
        {
            if(indexs[s[i]-'a'] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end

