using Leetcode.Models;

namespace Leetcode;

public class RangeSumOfBST
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        return RangeSumBstTree(root, low, high);
    }

    int RangeSumBstTree(TreeNode root, int low, int high)
    {
        if (root == null) return 0;

        var sum = 0;
        if (root.val > low)
        {
            sum += RangeSumBstTree(root.left, low, high);
        } 

        if (root.val < high)
        {
            sum += RangeSumBstTree(root.right, low, high);
        }
        // var sum = RangeSumBstTree(root.left, low, high) + RangeSumBstTree(root.right, low, high);
        if (root.val >= low && root.val <= high)
        {
            return sum + root.val;
        }

        return sum;
    }
}