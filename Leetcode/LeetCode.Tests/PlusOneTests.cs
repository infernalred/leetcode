using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class PlusOneTests
{
    [Fact]
    public void Test1()
    {
        var actual = PlusOne.GetPlusOne(new []{1,2,3});
        
        Assert.Equal(new []{1,2,4}, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = PlusOne.GetPlusOne(new []{4,3,2,1});
        
        Assert.Equal(new []{4,3,2,2}, actual);
    }
    
    [Fact]
    public void Test3()
    {
        var actual = PlusOne.GetPlusOne(new []{9});
        
        Assert.Equal(new []{1,0}, actual);
    }
}