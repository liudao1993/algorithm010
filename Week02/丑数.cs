
// 编写一个程序判断给定的数是否为丑数。

// 丑数就是只包含质因数 2, 3, 5 的正整数。

// 示例 1:

// 输入: 6
// 输出: true
// 解释: 6 = 2 × 3
// 示例 2:

// 输入: 8
// 输出: true
// 解释: 8 = 2 × 2 × 2
// 示例 3:

// 输入: 14
// 输出: false 
// 解释: 14 不是丑数，因为它包含了另外一个质因数 7。
// 说明：

// 1 是丑数。
// 输入不会超过 32 位有符号整数的范围: [−231,  231 − 1]。

public class Solution {
    public int NthUglyNumber(int n) {
        int a = 0, b = 0, c = 0;
        int[] dp = new int[n];
        dp[0] = 1;
        for(int i = 1; i < n; i++) {
            int n2 = dp[a] * 2, n3 = dp[b] * 3, n5 = dp[c] * 5;
            dp[i] = Math.Min(Math.Min(n2, n3), n5);
            if(dp[i] == n2) a++;
            if(dp[i] == n3) b++;
            if(dp[i] == n5) c++;
        }
        return dp[n - 1];
    }
}

