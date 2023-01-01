using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class ValidAnagramTests
{
    [Fact]
    public void Test1()
    {
        var actual = ValidAnagram.IsAnagram("anagram", "nagaram");
        
        Assert.True(actual);
    }
}