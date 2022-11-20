using Leetcode.Models;

namespace Leetcode;

public class PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        if (root.left == null && root.right == null)
            return root.val == targetSum;

        return HasPathSum(root.left, targetSum - root.val) 
               || HasPathSum(root.right, targetSum - root.val);
    }
}