using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class MajorityElementTest
{
    [Fact]
    public void Test1()
    {
        var actual = MajorityElement.GetMajorityElement(new []{3,2,3});
        
        Assert.Equal(3, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = MajorityElement.GetMajorityElement(new []{2,2,1,1,1,2,2});
        
        Assert.Equal(2, actual);
    }
}