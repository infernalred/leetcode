using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class ClimbingStairsTests
{
    [Fact]
    public void Test1()
    {
        var actual = ClimbingStairs.ClimbStairs(2);
        
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = ClimbingStairs.ClimbStairs(3);
        
        Assert.Equal(3, actual);
    }
}