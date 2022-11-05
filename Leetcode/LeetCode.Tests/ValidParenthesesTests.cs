using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class ValidParenthesesTests
{
    [Fact]
    public void Test1()
    {
        var actual = ValidParentheses.IsValid("()");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void Test2()
    {
        var actual = ValidParentheses.IsValid("()[]{}");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void Test3()
    {
        var actual = ValidParentheses.IsValid("(]");
        
        Assert.False(actual);
    }
    
    [Fact]
    public void Test4()
    {
        var actual = ValidParentheses.IsValid("()");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void Test5()
    {
        var actual = ValidParentheses.IsValid("]");
        
        Assert.False(actual);
    }
    
    [Fact]
    public void Test6()
    {
        var actual = ValidParentheses.IsValid("(])");
        
        Assert.False(actual);
    }
}