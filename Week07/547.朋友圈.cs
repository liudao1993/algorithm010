/*
 * @lc app=leetcode.cn id=547 lang=csharp
 *
 * [547] 朋友圈
 */

// @lc code=start
public class Solution {
    public int FindCircleNum(int[][] M) {
        if (M == null || M.Length <= 0 || M[0].Length <= 0){
            return -1;
        }

        int len = M.Length;

        bool[] visited = new bool[len];

        int count = 0;

        for (int i = 0; i < len; ++i)
        {
           if (!visited[i])
            {
                dfs(M, visited, i);
                count++;
            }
        }

        return count;
    }

    private void dfs(int[][] M, bool[] visited, int id)
    {
        for (int i = 0; i < M.Length; ++i)
        {
            if (M[id][i] == 1 && !visited[i])
            {
                visited[i] = true;
                dfs(M, visited, i);
            }
        }
    }
}
// @lc code=end

