using Leetcode;
using Leetcode.Models;
using Xunit;

namespace LeetCode.Tests;

public class RangeSumOfBSTTests
{
    [Fact]
    public void Test1()
    {
        var left01 = new TreeNode(1);
        var left11 = new TreeNode(6);
        
        var left21 = new TreeNode(3, left: left01);
        var right21 = new TreeNode(7, right: left11);

        var left22 = new TreeNode(13);
        var right22 = new TreeNode(18);
        
        var left1 = new TreeNode(5, left21, right21);
        var right1 = new TreeNode(15, left22, right22);

        var root = new TreeNode(10, left1, right1);

        var service = new RangeSumOfBST();
        var actual = service.RangeSumBST(root, 6, 10);
        
        Assert.Equal(23, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var left21 = new TreeNode(3);
        var right21 = new TreeNode(7);

        var right22 = new TreeNode(18);
        
        var left1 = new TreeNode(5, left21, right21);
        var right1 = new TreeNode(15, null, right22);

        var root = new TreeNode(10, left1, right1);

        var service = new RangeSumOfBST();
        var actual = service.RangeSumBST(root, 7, 15);
        
        Assert.Equal(32, actual);
    }
}