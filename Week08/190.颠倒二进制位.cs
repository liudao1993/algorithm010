/*
 * @lc app=leetcode.cn id=190 lang=csharp
 *
 * [190] 颠倒二进制位
 */

// @lc code=start
public class Solution {
    public uint reverseBits(uint n) 
    {
        uint result = 0;
        for(int i = 0; i < 32;i++)    
        {
            result += ((n & (1U << (31 - i))) != 0 ? 1U << i : 0);
        }
        return result;
    }
}
// @lc code=end

