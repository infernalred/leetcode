using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class LongestCommonPrefixTests
{
    [Fact]
    public void Test1()
    {
        var actual = LongestCommonPrefix.GetLongestCommonPrefix(new []{"flower","flow","flight"});
        
        Assert.Equal("fl", actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = LongestCommonPrefix.GetLongestCommonPrefix(new []{"dog","racecar","car"});
        
        Assert.Equal("", actual);
    }
    
    [Fact]
    public void Test3()
    {
        var actual = LongestCommonPrefix.GetLongestCommonPrefix(new []{"a"});
        
        Assert.Equal("a", actual);
    }
    
    [Fact]
    public void Test4()
    {
        var actual = LongestCommonPrefix.GetLongestCommonPrefix(new []{"ab", "a"});
        
        Assert.Equal("a", actual);
    }
    
    [Fact]
    public void Test5()
    {
        var actual = LongestCommonPrefix.GetLongestCommonPrefix(new []{"flower","flower","flower","flower"});
        
        Assert.Equal("flower", actual);
    }
}