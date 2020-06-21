/*
 * @lc app=leetcode.cn id=589 lang=csharp
 *
 * [589] N叉树的前序遍历
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
        public IList<int> Preorder(Node root)
        {
            m_list = new List<int>();
            Dfs(root);
            return m_list;
        }

        private List<int> m_list;

        private void Dfs(Node root)
        {
            if (root == null) return;

            m_list.Add(root.val);

            foreach (var item in root.children)
                Dfs(item);
        }
}
// @lc code=end

