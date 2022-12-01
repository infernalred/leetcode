using Leetcode.Models;

namespace Leetcode;

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        var depth = 0;
        
        if (root == null) return depth;

        depth++;

        if (root.left == null && root.right == null)
            return depth;

        depth += Math.Max(MaxDepth(root.left), MaxDepth(root.right));

        return depth;
    }
}