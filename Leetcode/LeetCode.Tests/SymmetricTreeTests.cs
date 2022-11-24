using Leetcode;
using Leetcode.Models;
using Xunit;

namespace LeetCode.Tests;

public class SymmetricTreeTests
{
    [Fact]
    public void Test1()
    {
        var left21 = new TreeNode(3);
        var right21 = new TreeNode(4);
        
        var left22 = new TreeNode(4);
        var right22 = new TreeNode(3);
        
        var left1 = new TreeNode(2, left21, right21);
        var right1 = new TreeNode(2, left22, right22);

        var root = new TreeNode(1, left1, right1);

        var service = new SymmetricTree();
        var actual = service.IsSymmetric(root);
        
        Assert.True(actual);
    }
}