/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            void GetNext(int l, int r)
            {
                //l>r   l==n
                //l>r   l<n
                //l==r  l<n
                //l==r  l==n
                if (l > r && l == n)
                {
                    sb.Append(')');
                    GetNext(l, r + 1);
                }
                else if (l > r && l < n)
                {
                    sb.Append('(');
                    GetNext(l + 1, r);
                    sb.Append(')');
                    GetNext(l, r + 1);
                }
                else if (l == r && l < n)
                {
                    sb.Append('(');
                    GetNext(l + 1, r);
                }
                else if (l == r && l == n)
                {
                    result.Add(sb.ToString());
                }
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append('(');
            GetNext(1, 0);
            return result;
    }
}
// @lc code=end

