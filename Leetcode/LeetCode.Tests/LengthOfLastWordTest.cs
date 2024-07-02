using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class LengthOfLastWordTest
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    public void Test1(string x, int result)
    {
        Assert.Equal(result, LengthOfLastWord.GetLengthOfLastWord(x));
    }
}