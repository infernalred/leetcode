using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class RomanToIntegerTests
{
    [Fact]
    public void Test1()
    {
        const string input = "III";

        const int expect = 3;

        var actual = RomanToInteger.RomanToInt(input);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test2()
    {
        const string input = "LVIII";

        const int expect = 58;

        var actual = RomanToInteger.RomanToInt(input);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test3()
    {
        const string input = "MCMXCIV";

        const int expect = 1994;

        var actual = RomanToInteger.RomanToInt(input);
        
        Assert.Equal(expect, actual);
    }
}