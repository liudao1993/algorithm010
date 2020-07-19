/*
 * @lc app=leetcode.cn id=64 lang=csharp
 *
 * [64] 最小路径和
 */

// @lc code=start
public class Solution {
    public int MinPathSum(int[][] grid)
        {
            int heigth = grid.Length;
            int width = grid[0].Length;

            for (int i = 0; i < heigth; i++)
            {
               for(int j=0;j<width;j++)
                {
                    if (i == 0&&j!=0)
                    {
                        grid[i][j] = grid[i][j] + grid[i][j - 1];
                    }
                    else if(i!=0&&j==0)
                    {
                        grid[i][j] = grid[i][j] + grid[i-1][j];
                    }
                    else if(i!=0&&j!=0)
                    {
                        grid[i][j] = grid[i][j] + Math.Min(grid[i][j - 1], grid[i - 1][j]);
                    }
                }
            }

            return grid[heigth-1][width-1];
        }
}
// @lc code=end

