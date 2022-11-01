using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class TwoSumTest
{
    [Fact]
    public void Test1()
    {
        var nums = new int[]{2, 7, 11, 15};
        var target = 9;
        var actual = TwoSumTask.TwoSum(nums, target);
        
        Assert.Equal(new int[]{0,1}, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var nums = new int[]{3,2,4};
        var target = 6;
        var actual = TwoSumTask.TwoSum(nums, target);
        
        Assert.Equal(new int[]{1,2}, actual);
    }
    
    [Fact]
    public void Test3()
    {
        var nums = new int[]{3,2,3};
        var target = 6;
        var actual = TwoSumTask.TwoSum(nums, target);
        
        Assert.Equal(new int[]{0,2}, actual);
    }
}