using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class MissingNumberTests
{
    [Fact]
    public void Test1()
    {
        var actual = MissingNumber.GetMissingNumber(new []{3,0,1});
        
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = MissingNumber.GetMissingNumber(new []{9,6,4,2,3,5,7,0,1});
        
        Assert.Equal(8, actual);
    }
}