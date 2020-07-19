/*
 * @lc app=leetcode.cn id=32 lang=csharp
 *
 * [32] 最长有效括号
 */

// @lc code=start
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            if (s.Length == 0) return 0;
            var maxLen = 0;
            var len = 0;
            var boolArray = new bool[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (boolArray[j])
                        {

                        }
                        else if (s[j] == '(')
                        {
                            boolArray[j] = true;
                            boolArray[i] = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < boolArray.Length; i++)
            {
                
                if (boolArray[i])
                {
                    len++;
                }
                else
                {
                    if (maxLen < len) maxLen = len;
                    len = 0;
                }
            }
            if (maxLen < len) maxLen = len;

            return maxLen;
        }
    }
// @lc code=end

