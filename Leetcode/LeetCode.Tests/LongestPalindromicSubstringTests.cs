using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class LongestPalindromicSubstringTests
{
    [Fact]
    public void Test1()
    {
        var actual = LongestPalindromicSubstring.LongestPalindrome("babad");
        
        Assert.Equal("bab", actual);
    }
}