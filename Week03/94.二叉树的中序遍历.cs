/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> r=new List<int>();
        return Helper(root,r);
    }

    public IList<int> Helper(TreeNode root,IList<int> res){
        if(root!=null){
            if(root.left!=null){
                Helper(root.left,res);
            }
            res.Add(root.val); 
            if(root.right!=null){
                Helper(root.right,res);
            }
        }
        return res;
    }
}
// @lc code=end

