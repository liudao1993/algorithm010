/*
 * @lc app=leetcode.cn id=105 lang=csharp
 *
 * [105] 从前序与中序遍历序列构造二叉树
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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int ,int> h = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                h.Add(inorder[i], i);
            }
            return BuildTree(preorder, 0, preorder.Length - 1,  0, inorder.Length - 1, h);
        }
        public TreeNode BuildTree(int[] preorder, int preleft, int preright, int inleft, int inright, Dictionary<int, int> h)
        {
            if (preleft > preright || inleft > inright)
            {
                return null;
            }
            int rootval = preorder[preleft];
            int pindex = h[rootval];
            TreeNode root = new TreeNode(rootval);
            root.left = BuildTree(preorder, preleft + 1, pindex + preleft - inleft,  inleft, pindex - 1, h);
            root.right = BuildTree(preorder, pindex + preleft - inleft + 1, preright,  pindex + 1, inright, h);
            return root;
        }
    
}
// @lc code=end

