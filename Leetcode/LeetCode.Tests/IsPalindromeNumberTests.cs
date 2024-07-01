using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class IsPalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    public void Test1(int number, bool result)
    {
        Assert.Equal(result, IsPalindromeNumber.IsPalindrome(number));
    }
}