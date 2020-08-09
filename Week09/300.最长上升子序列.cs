/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长上升子序列
 */

// @lc code=start
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] a = new int[n];
        for(int i = 0; i < n; i ++)
        {
            a[i] = 1;
        }
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if(nums[i] > nums[j] && a[i] <= a[j])
                {
                    a[i]++;
                }
            }
        }
        int Max = 0;
        for(int i = 0; i < n; i++)
        {
            if(a[i] > Max)
                Max = a[i];
        }
        return Max;
    }
}
// @lc code=end

