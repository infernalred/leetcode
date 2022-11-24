using Leetcode.Models;

namespace Leetcode;

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return false;

        return IsSymmetricSubTree(root.left, root.right);
    }

    bool IsSymmetricSubTree(TreeNode left, TreeNode right)
    {
        if (left != null && right != null)
        {
            return left.val == right.val 
                   && IsSymmetricSubTree(left.left, right.right) 
                   && IsSymmetricSubTree(left.right, right.left);
        }
        return left == right;
    }
}