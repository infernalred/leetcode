using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class LengthOfLongestSubstringTests
{
    [Fact]
    public void Test1()
    {
        const string s = "abcabcbb";
        const int target = 3;
        var actual = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        
        Assert.Equal(target, actual);
    }
}